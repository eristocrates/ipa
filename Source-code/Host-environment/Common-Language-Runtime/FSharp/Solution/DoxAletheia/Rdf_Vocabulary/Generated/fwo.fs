namespace https.w3id.org.foodwaste.ontology.hash

open DoxAletheia.Rdf_Vocabulary

module fwo =
    let _namespace_name = "https://w3id.org/foodwaste/ontology#"

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#6832c9d165d2ec4756cab2ed_Donor"></see>
    /// </summary>
    let _6832c9d165d2ec4756cab2ed_Donor =
        Namespaced_IRI.parse _namespace_name "6832c9d165d2ec4756cab2ed_Donor" |> NamespacedName

    /// <summary>
    /// User is a donor
    /// <see href="https://w3id.org/foodwaste/ontology#Donor"></see></summary>
    let Donor = Namespaced_IRI.parse _namespace_name "Donor" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#6841464540dd1a066f42dc98_Donor"></see>
    /// </summary>
    let _6841464540dd1a066f42dc98_Donor =
        Namespaced_IRI.parse _namespace_name "6841464540dd1a066f42dc98_Donor" |> NamespacedName

    /// <summary>
    /// An enumeration of substances that may cause allergic reactions.
    /// <see href="https://w3id.org/foodwaste/ontology#Allergen"></see></summary>
    let Allergen = Namespaced_IRI.parse _namespace_name "Allergen" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Crustacean_shellfish"></see>
    /// </summary>
    let Crustacean_shellfish =
        Namespaced_IRI.parse _namespace_name "Crustacean_shellfish" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Eggs"></see>
    /// </summary>
    let Eggs = Namespaced_IRI.parse _namespace_name "Eggs" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Fish"></see>
    /// </summary>
    let Fish = Namespaced_IRI.parse _namespace_name "Fish" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Milk"></see>
    /// </summary>
    let Milk = Namespaced_IRI.parse _namespace_name "Milk" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Sesame"></see>
    /// </summary>
    let Sesame = Namespaced_IRI.parse _namespace_name "Sesame" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Soybeans"></see>
    /// </summary>
    let Soybeans = Namespaced_IRI.parse _namespace_name "Soybeans" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Tree_Nuts"></see>
    /// </summary>
    let Tree_Nuts = Namespaced_IRI.parse _namespace_name "Tree_Nuts" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Wheat"></see>
    /// </summary>
    let Wheat = Namespaced_IRI.parse _namespace_name "Wheat" |> NamespacedName

    /// <summary>
    /// A food donation that is nearing its expiry and should be prioritized.
    /// <see href="https://w3id.org/foodwaste/ontology#AtRiskDonation"></see></summary>
    let AtRiskDonation =
        Namespaced_IRI.parse _namespace_name "AtRiskDonation" |> NamespacedName

    /// <summary>
    /// A record representing a donation of food items.
    /// <see href="https://w3id.org/foodwaste/ontology#FoodDonation"></see></summary>
    let FoodDonation =
        Namespaced_IRI.parse _namespace_name "FoodDonation" |> NamespacedName

    /// <summary>
    /// Specifies the priority level assigned to a donation.
    /// <see href="https://w3id.org/foodwaste/ontology#hasPriority"></see></summary>
    let hasPriority =
        Namespaced_IRI.parse _namespace_name "hasPriority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#High"></see>
    /// </summary>
    let High = Namespaced_IRI.parse _namespace_name "High" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Available"></see>
    /// </summary>
    let Available = Namespaced_IRI.parse _namespace_name "Available" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#BakedGoods"></see>
    /// </summary>
    let BakedGoods = Namespaced_IRI.parse _namespace_name "BakedGoods" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Beverages"></see>
    /// </summary>
    let Beverages = Namespaced_IRI.parse _namespace_name "Beverages" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Claimed"></see>
    /// </summary>
    let Claimed = Namespaced_IRI.parse _namespace_name "Claimed" |> NamespacedName

    /// <summary>
    /// A food donation that has been claimed by a recipient.
    /// <see href="https://w3id.org/foodwaste/ontology#ClaimedDonation"></see></summary>
    let ClaimedDonation =
        Namespaced_IRI.parse _namespace_name "ClaimedDonation" |> NamespacedName

    /// <summary>
    /// Associates a donation with its current status.
    /// <see href="https://w3id.org/foodwaste/ontology#hasDonationStatus"></see></summary>
    let hasDonationStatus =
        Namespaced_IRI.parse _namespace_name "hasDonationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#CookedFood"></see>
    /// </summary>
    let CookedFood = Namespaced_IRI.parse _namespace_name "CookedFood" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Dairy"></see>
    /// </summary>
    let Dairy = Namespaced_IRI.parse _namespace_name "Dairy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#DairyProducts"></see>
    /// </summary>
    let DairyProducts =
        Namespaced_IRI.parse _namespace_name "DairyProducts" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Delivered"></see>
    /// </summary>
    let Delivered = Namespaced_IRI.parse _namespace_name "Delivered" |> NamespacedName

    /// <summary>
    /// An enumeration of possible statuses for a food donation (e.g., At Risk, Claimed).
    /// <see href="https://w3id.org/foodwaste/ontology#DonationStatus"></see></summary>
    let DonationStatus =
        Namespaced_IRI.parse _namespace_name "DonationStatus" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Diabetic_Sweets"></see>
    /// </summary>
    let Diabetic_Sweets =
        Namespaced_IRI.parse _namespace_name "Diabetic_Sweets" |> NamespacedName

    /// <summary>
    /// An individual or organization interacting with the food wastage system.
    /// <see href="https://w3id.org/foodwaste/ontology#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// User is an NGO
    /// <see href="https://w3id.org/foodwaste/ontology#NGO"></see></summary>
    let NGO = Namespaced_IRI.parse _namespace_name "NGO" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor1"></see>
    /// </summary>
    let Donor1 = Namespaced_IRI.parse _namespace_name "Donor1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor10"></see>
    /// </summary>
    let Donor10 = Namespaced_IRI.parse _namespace_name "Donor10" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Donor_xyzq"></see>
    /// </summary>
    let Donor_xyzq = Namespaced_IRI.parse _namespace_name "Donor_xyzq" |> NamespacedName

    /// <summary>
    /// Denotes that a donation includes a specified allergen.
    /// <see href="https://w3id.org/foodwaste/ontology#containsAllergen"></see></summary>
    let containsAllergen =
        Namespaced_IRI.parse _namespace_name "containsAllergen" |> NamespacedName

    /// <summary>
    /// An enumeration of categories of food (e.g., fruits, vegetables, dairy)
    /// <see href="https://w3id.org/foodwaste/ontology#FoodType"></see></summary>
    let FoodType = Namespaced_IRI.parse _namespace_name "FoodType" |> NamespacedName

    /// <summary>
    /// Specifies the type of food in this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#hasFoodType"></see></summary>
    let hasFoodType =
        Namespaced_IRI.parse _namespace_name "hasFoodType" |> NamespacedName

    /// <summary>
    /// An ordered enumeration indicating the urgency or importance of a donation.
    /// <see href="https://w3id.org/foodwaste/ontology#Priority"></see></summary>
    let Priority = Namespaced_IRI.parse _namespace_name "Priority" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#FreshProduce"></see>
    /// </summary>
    let FreshProduce =
        Namespaced_IRI.parse _namespace_name "FreshProduce" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Grains_and_Cerals"></see>
    /// </summary>
    let Grains_and_Cerals =
        Namespaced_IRI.parse _namespace_name "Grains_and_Cerals" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Meat"></see>
    /// </summary>
    let Meat = Namespaced_IRI.parse _namespace_name "Meat" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Non_Diabetic_Sweets"></see>
    /// </summary>
    let Non_Diabetic_Sweets =
        Namespaced_IRI.parse _namespace_name "Non_Diabetic_Sweets" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Processed_and_Packaged"></see>
    /// </summary>
    let Processed_and_Packaged =
        Namespaced_IRI.parse _namespace_name "Processed_and_Packaged" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Sea_Food"></see>
    /// </summary>
    let Sea_Food = Namespaced_IRI.parse _namespace_name "Sea_Food" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Snacks"></see>
    /// </summary>
    let Snacks = Namespaced_IRI.parse _namespace_name "Snacks" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Spices_and_Condiments"></see>
    /// </summary>
    let Spices_and_Condiments =
        Namespaced_IRI.parse _namespace_name "Spices_and_Condiments" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Staple_Foods"></see>
    /// </summary>
    let Staple_Foods =
        Namespaced_IRI.parse _namespace_name "Staple_Foods" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Fruit"></see>
    /// </summary>
    let Fruit = Namespaced_IRI.parse _namespace_name "Fruit" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Gluten"></see>
    /// </summary>
    let Gluten = Namespaced_IRI.parse _namespace_name "Gluten" |> NamespacedName

    /// <summary>
    /// Indicates that one priority level is higher than another.
    /// <see href="https://w3id.org/foodwaste/ontology#hasHigherPriorityThan"></see></summary>
    let hasHigherPriorityThan =
        Namespaced_IRI.parse _namespace_name "hasHigherPriorityThan" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Medium"></see>
    /// </summary>
    let Medium = Namespaced_IRI.parse _namespace_name "Medium" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Low"></see>
    /// </summary>
    let Low = Namespaced_IRI.parse _namespace_name "Low" |> NamespacedName

    /// <summary>
    /// Links a user to an allergen they need to avoid
    /// <see href="https://w3id.org/foodwaste/ontology#avoidsAllergen"></see></summary>
    let avoidsAllergen =
        Namespaced_IRI.parse _namespace_name "avoidsAllergen" |> NamespacedName

    /// <summary>
    /// Links a user to the types of food they prefer.
    /// <see href="https://w3id.org/foodwaste/ontology#prefersFoodType"></see></summary>
    let prefersFoodType =
        Namespaced_IRI.parse _namespace_name "prefersFoodType" |> NamespacedName

    /// <summary>
    /// links user to the food type they reject
    /// <see href="https://w3id.org/foodwaste/ontology#rejectsFoodType"></see></summary>
    let rejectsFoodType =
        Namespaced_IRI.parse _namespace_name "rejectsFoodType" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#NGO1"></see>
    /// </summary>
    let NGO1 = Namespaced_IRI.parse _namespace_name "NGO1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#NGO2"></see>
    /// </summary>
    let NGO2 = Namespaced_IRI.parse _namespace_name "NGO2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Peanut"></see>
    /// </summary>
    let Peanut = Namespaced_IRI.parse _namespace_name "Peanut" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#Peanuts"></see>
    /// </summary>
    let Peanuts = Namespaced_IRI.parse _namespace_name "Peanuts" |> NamespacedName

    /// <summary>
    /// A donation marked as preferred by a user based on their preferences.
    /// <see href="https://w3id.org/foodwaste/ontology#PreferredDonation"></see></summary>
    let PreferredDonation =
        Namespaced_IRI.parse _namespace_name "PreferredDonation" |> NamespacedName

    /// <summary>
    /// A donation from a source flagged as trusted.
    /// <see href="https://w3id.org/foodwaste/ontology#TrustedDonation"></see></summary>
    let TrustedDonation =
        Namespaced_IRI.parse _namespace_name "TrustedDonation" |> NamespacedName

    /// <summary>
    /// A donation requiring immediate pickup or distribution
    /// <see href="https://w3id.org/foodwaste/ontology#UrgentDonation"></see></summary>
    let UrgentDonation =
        Namespaced_IRI.parse _namespace_name "UrgentDonation" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc123"></see>
    /// </summary>
    let abc123 = Namespaced_IRI.parse _namespace_name "abc123" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc1234"></see>
    /// </summary>
    let abc1234 = Namespaced_IRI.parse _namespace_name "abc1234" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#abc123_Location"></see>
    /// </summary>
    let abc123_Location =
        Namespaced_IRI.parse _namespace_name "abc123_Location" |> NamespacedName

    /// <summary>
    /// Indicates the user who has claimed this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#claimedBy"></see></summary>
    let claimedBy = Namespaced_IRI.parse _namespace_name "claimedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#don12345_Location"></see>
    /// </summary>
    let don12345_Location =
        Namespaced_IRI.parse _namespace_name "don12345_Location" |> NamespacedName

    /// <summary>
    /// Indicates the user or farmer who made this donation.
    /// <see href="https://w3id.org/foodwaste/ontology#donatedBy"></see></summary>
    let donatedBy = Namespaced_IRI.parse _namespace_name "donatedBy" |> NamespacedName
    /// <summary>
    /// Links a user to the donations they have made.
    /// <see href="https://w3id.org/foodwaste/ontology#hasDonated"></see></summary>
    let hasDonated = Namespaced_IRI.parse _namespace_name "hasDonated" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#donor456_Donor"></see>
    /// </summary>
    let donor456_Donor =
        Namespaced_IRI.parse _namespace_name "donor456_Donor" |> NamespacedName

    /// <summary>
    /// Denotes the expiration date of a donated food item
    /// <see href="https://w3id.org/foodwaste/ontology#hasExpiryDate"></see></summary>
    let hasExpiryDate =
        Namespaced_IRI.parse _namespace_name "hasExpiryDate" |> NamespacedName

    /// <summary>
    /// Indicates that one priority level is lower than another.
    /// <see href="https://w3id.org/foodwaste/ontology#hasLowerPriorityThan"></see></summary>
    let hasLowerPriorityThan =
        Namespaced_IRI.parse _namespace_name "hasLowerPriorityThan" |> NamespacedName

    /// <summary>
    /// Relates a food type to its more general parent category.
    /// <see href="https://w3id.org/foodwaste/ontology#hasParentType"></see></summary>
    let hasParentType =
        Namespaced_IRI.parse _namespace_name "hasParentType" |> NamespacedName

    /// <summary>
    /// Indicates that a donation is preferred by a particular user.
    /// <see href="https://w3id.org/foodwaste/ontology#isPreferredBy"></see></summary>
    let isPreferredBy =
        Namespaced_IRI.parse _namespace_name "isPreferredBy" |> NamespacedName

    /// <summary>
    /// Indicates that a donation type has been rejected by a particular user.
    /// <see href="https://w3id.org/foodwaste/ontology#isRejectedBy"></see></summary>
    let isRejectedBy =
        Namespaced_IRI.parse _namespace_name "isRejectedBy" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#xyz1234"></see>
    /// </summary>
    let xyz1234 = Namespaced_IRI.parse _namespace_name "xyz1234" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/foodwaste/ontology#xyzq_Donor"></see>
    /// </summary>
    let xyzq_Donor = Namespaced_IRI.parse _namespace_name "xyzq_Donor" |> NamespacedName
