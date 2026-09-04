#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module fwo =
    let _prefixId =
        PrefixId.fromNamespaceLabel "https://w3id.org/foodwaste/ontology#" "fwo"

    let _6832c9d165d2ec4756cab2ed_Donor =
        _prefixId.prefix "6832c9d165d2ec4756cab2ed_Donor"

    let _6841464540dd1a066f42dc98_Donor =
        _prefixId.prefix "6841464540dd1a066f42dc98_Donor"

    /// <summary>
    ///   <para>rdfs:label : Allergens^^xsd:string</para>
    ///   <para>rdfs:comment : An enumeration of substances that may cause allergic reactions.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#Allergen">fwo:Allergen</a>
    /// </summary>
    let Allergen = _prefixId.prefix "Allergen"
    /// <summary>
    ///   <para>rdfs:label : At‑Risk Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A food donation that is nearing its expiry and should be prioritized.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#AtRiskDonation">fwo:AtRiskDonation</a>
    /// </summary>
    let AtRiskDonation = _prefixId.prefix "AtRiskDonation"
    let Available = _prefixId.prefix "Available"
    let BakedGoods = _prefixId.prefix "BakedGoods"
    let Beverages = _prefixId.prefix "Beverages"
    let Claimed = _prefixId.prefix "Claimed"
    /// <summary>
    ///   <para>rdfs:label : Claimed Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A food donation that has been claimed by a recipient.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#ClaimedDonation">fwo:ClaimedDonation</a>
    /// </summary>
    let ClaimedDonation = _prefixId.prefix "ClaimedDonation"
    let CookedFood = _prefixId.prefix "CookedFood"
    let Crustacean_shellfish = _prefixId.prefix "Crustacean_shellfish"
    let Dairy = _prefixId.prefix "Dairy"
    let DairyProducts = _prefixId.prefix "DairyProducts"
    let Delivered = _prefixId.prefix "Delivered"
    let Diabetic_Sweets = _prefixId.prefix "Diabetic_Sweets"
    /// <summary>
    ///   <para>rdfs:label : Donation Status^^xsd:string</para>
    ///   <para>rdfs:comment : An enumeration of possible statuses for a food donation (e.g., At Risk, Claimed).^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#DonationStatus">fwo:DonationStatus</a>
    /// </summary>
    let DonationStatus = _prefixId.prefix "DonationStatus"
    /// <summary>
    ///   <para>rdfs:label : Donor^^xsd:string</para>
    ///   <para>rdfs:comment : User is a donor^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#Donor">fwo:Donor</a>
    /// </summary>
    let Donor = _prefixId.prefix "Donor"
    let Donor1 = _prefixId.prefix "Donor1"
    let Donor10 = _prefixId.prefix "Donor10"
    let Donor_xyzq = _prefixId.prefix "Donor_xyzq"
    let Eggs = _prefixId.prefix "Eggs"
    let Fish = _prefixId.prefix "Fish"
    /// <summary>
    ///   <para>rdfs:label : Food Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A record representing a donation of food items.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#FoodDonation">fwo:FoodDonation</a>
    /// </summary>
    let FoodDonation = _prefixId.prefix "FoodDonation"
    /// <summary>
    ///   <para>rdfs:label : Food Type^^xsd:string</para>
    ///   <para>rdfs:comment : An enumeration of categories of food (e.g., fruits, vegetables, dairy)^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#FoodType">fwo:FoodType</a>
    /// </summary>
    let FoodType = _prefixId.prefix "FoodType"
    let FreshProduce = _prefixId.prefix "FreshProduce"
    let Fruit = _prefixId.prefix "Fruit"
    let Gluten = _prefixId.prefix "Gluten"
    let Grains_and_Cerals = _prefixId.prefix "Grains_and_Cerals"
    let High = _prefixId.prefix "High"
    let Low = _prefixId.prefix "Low"
    let Meat = _prefixId.prefix "Meat"
    let Medium = _prefixId.prefix "Medium"
    let Milk = _prefixId.prefix "Milk"
    /// <summary>
    ///   <para>rdfs:label : NGO^^xsd:string</para>
    ///   <para>rdfs:comment : User is an NGO^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#NGO">fwo:NGO</a>
    /// </summary>
    let NGO = _prefixId.prefix "NGO"
    let NGO1 = _prefixId.prefix "NGO1"
    let NGO2 = _prefixId.prefix "NGO2"
    let Non_Diabetic_Sweets = _prefixId.prefix "Non_Diabetic_Sweets"
    let Peanut = _prefixId.prefix "Peanut"
    let Peanuts = _prefixId.prefix "Peanuts"
    /// <summary>
    ///   <para>rdfs:label : Preferred Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A donation marked as preferred by a user based on their preferences.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#PreferredDonation">fwo:PreferredDonation</a>
    /// </summary>
    let PreferredDonation = _prefixId.prefix "PreferredDonation"
    /// <summary>
    ///   <para>rdfs:label : Priority^^xsd:string</para>
    ///   <para>rdfs:comment : An ordered enumeration indicating the urgency or importance of a donation.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#Priority">fwo:Priority</a>
    /// </summary>
    let Priority = _prefixId.prefix "Priority"
    let Processed_and_Packaged = _prefixId.prefix "Processed_and_Packaged"
    let Sea_Food = _prefixId.prefix "Sea_Food"
    let Sesame = _prefixId.prefix "Sesame"
    let Snacks = _prefixId.prefix "Snacks"
    let Soybeans = _prefixId.prefix "Soybeans"
    let Spices_and_Condiments = _prefixId.prefix "Spices_and_Condiments"
    let Staple_Foods = _prefixId.prefix "Staple_Foods"
    let Tree_Nuts = _prefixId.prefix "Tree_Nuts"
    /// <summary>
    ///   <para>rdfs:label : Trusted Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A donation from a source flagged as trusted.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#TrustedDonation">fwo:TrustedDonation</a>
    /// </summary>
    let TrustedDonation = _prefixId.prefix "TrustedDonation"
    /// <summary>
    ///   <para>rdfs:label : Urgent Donation^^xsd:string</para>
    ///   <para>rdfs:comment : A donation requiring immediate pickup or distribution^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#UrgentDonation">fwo:UrgentDonation</a>
    /// </summary>
    let UrgentDonation = _prefixId.prefix "UrgentDonation"
    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <para>rdfs:comment : An individual or organization interacting with the food wastage system.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#User">fwo:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    let Wheat = _prefixId.prefix "Wheat"
    let abc123 = _prefixId.prefix "abc123"
    let abc1234 = _prefixId.prefix "abc1234"
    let abc123_Location = _prefixId.prefix "abc123_Location"
    /// <summary>
    ///   <para>rdfs:label : avoids Allergen^^xsd:string</para>
    ///   <para>rdfs:comment : Links a user to an allergen they need to avoid^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#avoidsAllergen">fwo:avoidsAllergen</a>
    /// </summary>
    let avoidsAllergen = _prefixId.prefix "avoidsAllergen"
    /// <summary>
    ///   <para>rdfs:label : claimed by^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the user who has claimed this donation.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#claimedBy">fwo:claimedBy</a>
    /// </summary>
    let claimedBy = _prefixId.prefix "claimedBy"
    /// <summary>
    ///   <para>rdfs:label : contains Allergen^^xsd:string</para>
    ///   <para>rdfs:comment : Denotes that a donation includes a specified allergen.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#containsAllergen">fwo:containsAllergen</a>
    /// </summary>
    let containsAllergen = _prefixId.prefix "containsAllergen"
    let don12345_Location = _prefixId.prefix "don12345_Location"
    /// <summary>
    ///   <para>rdfs:label : donated by^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the user or farmer who made this donation.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#donatedBy">fwo:donatedBy</a>
    /// </summary>
    let donatedBy = _prefixId.prefix "donatedBy"
    let donor456_Donor = _prefixId.prefix "donor456_Donor"
    /// <summary>
    ///   <para>rdfs:label : has donated^^xsd:string</para>
    ///   <para>rdfs:comment : Links a user to the donations they have made.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasDonated">fwo:hasDonated</a>
    /// </summary>
    let hasDonated = _prefixId.prefix "hasDonated"
    /// <summary>
    ///   <para>rdfs:label : has donation status^^xsd:string</para>
    ///   <para>rdfs:comment : Associates a donation with its current status.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasDonationStatus">fwo:hasDonationStatus</a>
    /// </summary>
    let hasDonationStatus = _prefixId.prefix "hasDonationStatus"
    /// <summary>
    ///   <para>rdfs:label : has expiry date</para>
    ///   <para>rdfs:comment : Denotes the expiration date of a donated food item^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasExpiryDate">fwo:hasExpiryDate</a>
    /// </summary>
    let hasExpiryDate = _prefixId.prefix "hasExpiryDate"
    /// <summary>
    ///   <para>rdfs:label : has food type^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the type of food in this donation.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasFoodType">fwo:hasFoodType</a>
    /// </summary>
    let hasFoodType = _prefixId.prefix "hasFoodType"
    /// <summary>
    ///   <para>rdfs:label : has higher priority than^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that one priority level is higher than another.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasHigherPriorityThan">fwo:hasHigherPriorityThan</a>
    /// </summary>
    let hasHigherPriorityThan = _prefixId.prefix "hasHigherPriorityThan"
    /// <summary>
    ///   <para>rdfs:label : has lower priority than^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that one priority level is lower than another.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasLowerPriorityThan">fwo:hasLowerPriorityThan</a>
    /// </summary>
    let hasLowerPriorityThan = _prefixId.prefix "hasLowerPriorityThan"
    /// <summary>
    ///   <para>rdfs:label : has parent type^^xsd:string</para>
    ///   <para>rdfs:comment : Relates a food type to its more general parent category.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasParentType">fwo:hasParentType</a>
    /// </summary>
    let hasParentType = _prefixId.prefix "hasParentType"
    /// <summary>
    ///   <para>rdfs:label : has priority^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the priority level assigned to a donation.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#hasPriority">fwo:hasPriority</a>
    /// </summary>
    let hasPriority = _prefixId.prefix "hasPriority"
    /// <summary>
    ///   <para>rdfs:label : is preferred by^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a donation is preferred by a particular user.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#isPreferredBy">fwo:isPreferredBy</a>
    /// </summary>
    let isPreferredBy = _prefixId.prefix "isPreferredBy"
    /// <summary>
    ///   <para>rdfs:label : is rejected by^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a donation type has been rejected by a particular user.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#isRejectedBy">fwo:isRejectedBy</a>
    /// </summary>
    let isRejectedBy = _prefixId.prefix "isRejectedBy"
    /// <summary>
    ///   <para>rdfs:label : prefers food type^^xsd:string</para>
    ///   <para>rdfs:comment : Links a user to the types of food they prefer.^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#prefersFoodType">fwo:prefersFoodType</a>
    /// </summary>
    let prefersFoodType = _prefixId.prefix "prefersFoodType"
    /// <summary>
    ///   <para>rdfs:label : rejects food type^^xsd:string</para>
    ///   <para>rdfs:comment : links user to the food type they reject^^xsd:string</para>
    ///   <a href="https://w3id.org/foodwaste/ontology#rejectsFoodType">fwo:rejectsFoodType</a>
    /// </summary>
    let rejectsFoodType = _prefixId.prefix "rejectsFoodType"
    let xyz1234 = _prefixId.prefix "xyz1234"
    let xyzq_Donor = _prefixId.prefix "xyzq_Donor"
