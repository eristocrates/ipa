namespace https.w3id.org.timebank.hash

open DoxAletheia.Rdf_Vocabulary

module tb =
    let _namespace_name = "https://w3id.org/timebank#"

    /// <summary>
    /// Fear of animals. This can include dogs, cats, snakes, insects, etc.
    /// <see href="https://w3id.org/timebank#FearOfAnimals"></see></summary>
    let FearOfAnimals =
        Namespaced_IRI.parse _namespace_name "FearOfAnimals" |> NamespacedName

    /// <summary>
    /// Fear of dark places.
    /// <see href="https://w3id.org/timebank#FearOfDark"></see></summary>
    let FearOfDark = Namespaced_IRI.parse _namespace_name "FearOfDark" |> NamespacedName

    /// <summary>
    /// Fear or phobia of heights.
    /// <see href="https://w3id.org/timebank#FearOfHeights"></see></summary>
    let FearOfHeights =
        Namespaced_IRI.parse _namespace_name "FearOfHeights" |> NamespacedName

    /// <summary>
    /// A disorder characterized by high blood sugar levels during a long period.
    /// <see href="https://w3id.org/timebank#Diabetes"></see></summary>
    let Diabetes = Namespaced_IRI.parse _namespace_name "Diabetes" |> NamespacedName

    /// <summary>
    /// A condition of diseases that negatively affect one's heart such as blood vessel diseases and heart rhythm problems.
    /// <see href="https://w3id.org/timebank#HeartDisease"></see></summary>
    let HeartDisease =
        Namespaced_IRI.parse _namespace_name "HeartDisease" |> NamespacedName

    /// <summary>
    /// The blood pressure is high in a long period.
    /// <see href="https://w3id.org/timebank#Hypertension"></see></summary>
    let Hypertension =
        Namespaced_IRI.parse _namespace_name "Hypertension" |> NamespacedName

    /// <summary>
    /// The blood pressure is low in a long period.
    /// <see href="https://w3id.org/timebank#Hypotension"></see></summary>
    let Hypotension =
        Namespaced_IRI.parse _namespace_name "Hypotension" |> NamespacedName

    /// <summary>
    /// Diseases that causes chronic pain in joints and muscles such as back, shoulder and neck.
    /// <see href="https://w3id.org/timebank#Rheumatism"></see></summary>
    let Rheumatism = Namespaced_IRI.parse _namespace_name "Rheumatism" |> NamespacedName

    /// <summary>
    /// It indicates a person once had a storke. A stroke happens when blood flow to the brain is blocked and oxygen for the brain cells is insufficient, which could leads to cell death.
    /// <see href="https://w3id.org/timebank#StrokeHistory"></see></summary>
    let StrokeHistory =
        Namespaced_IRI.parse _namespace_name "StrokeHistory" |> NamespacedName

    /// <summary>
    /// Skills to provide particular services which requires some sort of education or training.
    /// <see href="https://w3id.org/timebank#Advice"></see></summary>
    let Advice = Namespaced_IRI.parse _namespace_name "Advice" |> NamespacedName
    /// <summary>
    /// Crafting skills.
    /// <see href="https://w3id.org/timebank#Crafting"></see></summary>
    let Crafting = Namespaced_IRI.parse _namespace_name "Crafting" |> NamespacedName

    /// <summary>
    /// The skill to provide services related to food products.
    /// <see href="https://w3id.org/timebank#FoodService"></see></summary>
    let FoodService =
        Namespaced_IRI.parse _namespace_name "FoodService" |> NamespacedName

    /// <summary>
    /// The skill to help with maintenance of equipment.
    /// <see href="https://w3id.org/timebank#Maintenance"></see></summary>
    let Maintenance =
        Namespaced_IRI.parse _namespace_name "Maintenance" |> NamespacedName

    /// <summary>
    /// The skill to provide help with office related work.
    /// <see href="https://w3id.org/timebank#OfficeWork"></see></summary>
    let OfficeWork = Namespaced_IRI.parse _namespace_name "OfficeWork" |> NamespacedName
    /// <summary>
    /// The skill to provide care for people.
    /// <see href="https://w3id.org/timebank#PeopleCare"></see></summary>
    let PeopleCare = Namespaced_IRI.parse _namespace_name "PeopleCare" |> NamespacedName

    /// <summary>
    /// Personal services which include hygiene and daily care.
    /// <see href="https://w3id.org/timebank#PersonalService"></see></summary>
    let PersonalService =
        Namespaced_IRI.parse _namespace_name "PersonalService" |> NamespacedName

    /// <summary>
    /// The skill to provide services related to recreation.
    /// <see href="https://w3id.org/timebank#Recreation"></see></summary>
    let Recreation = Namespaced_IRI.parse _namespace_name "Recreation" |> NamespacedName
    /// <summary>
    /// The Skill to repair equipment and facilities.
    /// <see href="https://w3id.org/timebank#Repair"></see></summary>
    let Repair = Namespaced_IRI.parse _namespace_name "Repair" |> NamespacedName

    /// <summary>
    /// The skill to help with selling and buying products.
    /// <see href="https://w3id.org/timebank#SalesService"></see></summary>
    let SalesService =
        Namespaced_IRI.parse _namespace_name "SalesService" |> NamespacedName

    /// <summary>
    /// The skill to provide services related to transportation.
    /// <see href="https://w3id.org/timebank#Transportation"></see></summary>
    let Transportation =
        Namespaced_IRI.parse _namespace_name "Transportation" |> NamespacedName

    /// <summary>
    /// The skill to assist someone with dressing.
    /// <see href="https://w3id.org/timebank#DressingAssistance"></see></summary>
    let DressingAssistance =
        Namespaced_IRI.parse _namespace_name "DressingAssistance" |> NamespacedName

    /// <summary>
    /// Ability to cut someone else's hair.
    /// <see href="https://w3id.org/timebank#HairCutting"></see></summary>
    let HairCutting =
        Namespaced_IRI.parse _namespace_name "HairCutting" |> NamespacedName

    /// <summary>
    /// The skill to assist someone on hygienical matters.
    /// <see href="https://w3id.org/timebank#HygieneAssitance"></see></summary>
    let HygieneAssitance =
        Namespaced_IRI.parse _namespace_name "HygieneAssitance" |> NamespacedName

    /// <summary>
    /// A collection of allergies, which is caused by hypersensitivity of the immune system.
    /// <see href="https://w3id.org/timebank#Allergy"></see></summary>
    let Allergy = Namespaced_IRI.parse _namespace_name "Allergy" |> NamespacedName

    /// <summary>
    /// A collection of diseases that are common, especially for elderly people
    /// <see href="https://w3id.org/timebank#CommonDisease"></see></summary>
    let CommonDisease =
        Namespaced_IRI.parse _namespace_name "CommonDisease" |> NamespacedName

    /// <summary>
    /// Disorders that affect the mental states of a person.
    /// <see href="https://w3id.org/timebank#MentalDisorder"></see></summary>
    let MentalDisorder =
        Namespaced_IRI.parse _namespace_name "MentalDisorder" |> NamespacedName

    /// <summary>
    /// This is a collection of physical disorders that negatively affect a person's daily life.
    /// <see href="https://w3id.org/timebank#PhysicalInconvenience"></see></summary>
    let PhysicalInconvenience =
        Namespaced_IRI.parse _namespace_name "PhysicalInconvenience" |> NamespacedName

    /// <summary>
    /// Experience in driving tractors.
    /// <see href="https://w3id.org/timebank#DrivingTractors"></see></summary>
    let DrivingTractors =
        Namespaced_IRI.parse _namespace_name "DrivingTractors" |> NamespacedName

    /// <summary>
    /// Experience in driving with trucks.
    /// <see href="https://w3id.org/timebank#DrivingTrucks"></see></summary>
    let DrivingTrucks =
        Namespaced_IRI.parse _namespace_name "DrivingTrucks" |> NamespacedName

    /// <summary>
    /// Experience in driving with trailers.
    /// <see href="https://w3id.org/timebank#DrivingWithTrailers"></see></summary>
    let DrivingWithTrailers =
        Namespaced_IRI.parse _namespace_name "DrivingWithTrailers" |> NamespacedName

    /// <summary>
    /// A person with cognitive impairment can't think and remember things clearly.
    /// <see href="https://w3id.org/timebank#CognitiveImpairment"></see></summary>
    let CognitiveImpairment =
        Namespaced_IRI.parse _namespace_name "CognitiveImpairment" |> NamespacedName

    /// <summary>
    /// A person with depression has a depressed mood over a long period and may even have thoughts of suicide.
    /// <see href="https://w3id.org/timebank#Depression"></see></summary>
    let Depression = Namespaced_IRI.parse _namespace_name "Depression" |> NamespacedName

    /// <summary>
    /// A person with psychotic episode can not tell the difference between the reality and unreality and may have difficulty with social activities in daily life.
    /// <see href="https://w3id.org/timebank#PsychoticEpisode"></see></summary>
    let PsychoticEpisode =
        Namespaced_IRI.parse _namespace_name "PsychoticEpisode" |> NamespacedName

    /// <summary>
    /// Fear of specific objects such as dogs, cats, heights, dark places, and so on.
    /// <see href="https://w3id.org/timebank#SpecificPhobia"></see></summary>
    let SpecificPhobia =
        Namespaced_IRI.parse _namespace_name "SpecificPhobia" |> NamespacedName

    /// <summary>
    /// The person has difficulty in climbing up stairs.
    /// <see href="https://w3id.org/timebank#ClimbingStairsDifficulty"></see></summary>
    let ClimbingStairsDifficulty =
        Namespaced_IRI.parse _namespace_name "ClimbingStairsDifficulty" |> NamespacedName

    /// <summary>
    /// The person has difficulties dressing himself.
    /// <see href="https://w3id.org/timebank#DressingProblem"></see></summary>
    let DressingProblem =
        Namespaced_IRI.parse _namespace_name "DressingProblem" |> NamespacedName

    /// <summary>
    /// The person has difficulties using toilet.
    /// <see href="https://w3id.org/timebank#ToiletUsingProblem"></see></summary>
    let ToiletUsingProblem =
        Namespaced_IRI.parse _namespace_name "ToiletUsingProblem" |> NamespacedName

    /// <summary>
    /// The person has difficulties walking.
    /// <see href="https://w3id.org/timebank#WalkingProblem"></see></summary>
    let WalkingProblem =
        Namespaced_IRI.parse _namespace_name "WalkingProblem" |> NamespacedName

    /// <summary>
    /// An allergy to drugs.
    /// <see href="https://w3id.org/timebank#DrugAllergy"></see></summary>
    let DrugAllergy =
        Namespaced_IRI.parse _namespace_name "DrugAllergy" |> NamespacedName

    /// <summary>
    /// An allergy to something in the environment such as dust mites, pollen, pet hair and cigarette smoke.
    /// <see href="https://w3id.org/timebank#EnvironmentalAllergy"></see></summary>
    let EnvironmentalAllergy =
        Namespaced_IRI.parse _namespace_name "EnvironmentalAllergy" |> NamespacedName

    /// <summary>
    /// An allergy to food such as milk, peanuts, eggs, fish, tree nuts, and fruit.
    /// <see href="https://w3id.org/timebank#FoodAllergy"></see></summary>
    let FoodAllergy =
        Namespaced_IRI.parse _namespace_name "FoodAllergy" |> NamespacedName

    /// <summary>
    /// The ability to act as a dancing companion.
    /// <see href="https://w3id.org/timebank#DancingCompanion"></see></summary>
    let DancingCompanion =
        Namespaced_IRI.parse _namespace_name "DancingCompanion" |> NamespacedName

    /// <summary>
    /// The skill to assist in planning and hosting events.
    /// <see href="https://w3id.org/timebank#EventPlanning"></see></summary>
    let EventPlanning =
        Namespaced_IRI.parse _namespace_name "EventPlanning" |> NamespacedName

    /// <summary>
    /// The skill to participate in board games, card games, etc.
    /// <see href="https://w3id.org/timebank#Games"></see></summary>
    let Games = Namespaced_IRI.parse _namespace_name "Games" |> NamespacedName

    /// <summary>
    /// The skill to entertain others by performing music.
    /// <see href="https://w3id.org/timebank#PerformingMusic"></see></summary>
    let PerformingMusic =
        Namespaced_IRI.parse _namespace_name "PerformingMusic" |> NamespacedName

    /// <summary>
    /// The skill to participate in sport activities.
    /// <see href="https://w3id.org/timebank#Sports"></see></summary>
    let Sports = Namespaced_IRI.parse _namespace_name "Sports" |> NamespacedName

    /// <summary>
    /// The ability to act as a travel companion.
    /// <see href="https://w3id.org/timebank#TravelCompanion"></see></summary>
    let TravelCompanion =
        Namespaced_IRI.parse _namespace_name "TravelCompanion" |> NamespacedName

    /// <summary>
    /// The skill to assemble items like furniture and other things.
    /// <see href="https://w3id.org/timebank#Assembling"></see></summary>
    let Assembling = Namespaced_IRI.parse _namespace_name "Assembling" |> NamespacedName

    /// <summary>
    /// The ability to craft any kind of clothes.
    /// <see href="https://w3id.org/timebank#CraftingClothes"></see></summary>
    let CraftingClothes =
        Namespaced_IRI.parse _namespace_name "CraftingClothes" |> NamespacedName

    /// <summary>
    /// Crafting skill with wood as base material.
    /// <see href="https://w3id.org/timebank#WoodCrafting"></see></summary>
    let WoodCrafting =
        Namespaced_IRI.parse _namespace_name "WoodCrafting" |> NamespacedName

    /// <summary>
    /// The location is accessible by public transport.
    /// <see href="https://w3id.org/timebank#AccessibleByPublicTransport"></see></summary>
    let AccessibleByPublicTransport =
        Namespaced_IRI.parse _namespace_name "AccessibleByPublicTransport" |> NamespacedName

    /// <summary>
    /// A lift/elevator is available.
    /// <see href="https://w3id.org/timebank#Lift"></see></summary>
    let Lift = Namespaced_IRI.parse _namespace_name "Lift" |> NamespacedName

    /// <summary>
    /// The person needs to be aware of slippery floor.
    /// <see href="https://w3id.org/timebank#SlipperyFloor"></see></summary>
    let SlipperyFloor =
        Namespaced_IRI.parse _namespace_name "SlipperyFloor" |> NamespacedName

    /// <summary>
    /// The person might have to climb stairs to complete the task.
    /// <see href="https://w3id.org/timebank#Stairs"></see></summary>
    let Stairs = Namespaced_IRI.parse _namespace_name "Stairs" |> NamespacedName

    /// <summary>
    /// Transportation necessary to complete the task can be provided.
    /// <see href="https://w3id.org/timebank#TransportationAvailable"></see></summary>
    let TransportationAvailable =
        Namespaced_IRI.parse _namespace_name "TransportationAvailable" |> NamespacedName

    /// <summary>
    /// The person needs equipment (e.g. shoes) suitable for uneven terrain.
    /// <see href="https://w3id.org/timebank#UnevenTerrain"></see></summary>
    let UnevenTerrain =
        Namespaced_IRI.parse _namespace_name "UnevenTerrain" |> NamespacedName

    /// <summary>
    /// The place is difficult to access during bad weather (e.g. snow).
    /// <see href="https://w3id.org/timebank#WeatherConstraint"></see></summary>
    let WeatherConstraint =
        Namespaced_IRI.parse _namespace_name "WeatherConstraint" |> NamespacedName

    /// <summary>
    /// The skill to advice people on psychological matters.
    /// <see href="https://w3id.org/timebank#Counseling"></see></summary>
    let Counseling = Namespaced_IRI.parse _namespace_name "Counseling" |> NamespacedName

    /// <summary>
    /// Specialized in providing assistance with financial services. This can include helping with taxes and book keeping.
    /// <see href="https://w3id.org/timebank#FinancialAdvice"></see></summary>
    let FinancialAdvice =
        Namespaced_IRI.parse _namespace_name "FinancialAdvice" |> NamespacedName

    /// <summary>
    /// Specialized in providing legal assistance.
    /// <see href="https://w3id.org/timebank#LegalAdvice"></see></summary>
    let LegalAdvice =
        Namespaced_IRI.parse _namespace_name "LegalAdvice" |> NamespacedName

    /// <summary>
    /// The skill to repair automobiles.
    /// <see href="https://w3id.org/timebank#AutomobileRepair"></see></summary>
    let AutomobileRepair =
        Namespaced_IRI.parse _namespace_name "AutomobileRepair" |> NamespacedName

    /// <summary>
    /// The skill to fix problems with computers.
    /// <see href="https://w3id.org/timebank#ComputerRepair"></see></summary>
    let ComputerRepair =
        Namespaced_IRI.parse _namespace_name "ComputerRepair" |> NamespacedName

    /// <summary>
    /// The skill to repair electronic devices.
    /// <see href="https://w3id.org/timebank#ElectronicRepair"></see></summary>
    let ElectronicRepair =
        Namespaced_IRI.parse _namespace_name "ElectronicRepair" |> NamespacedName

    /// <summary>
    /// The skill to repair household equipment.
    /// <see href="https://w3id.org/timebank#HouseholdEquipmentRepair"></see></summary>
    let HouseholdEquipmentRepair =
        Namespaced_IRI.parse _namespace_name "HouseholdEquipmentRepair" |> NamespacedName

    /// <summary>
    /// Skill to perform plumbing and repairs on pipe installation.
    /// <see href="https://w3id.org/timebank#Plumbing"></see></summary>
    let Plumbing = Namespaced_IRI.parse _namespace_name "Plumbing" |> NamespacedName
    /// <summary>
    /// The skill to assist with baking.
    /// <see href="https://w3id.org/timebank#Baking"></see></summary>
    let Baking = Namespaced_IRI.parse _namespace_name "Baking" |> NamespacedName
    /// <summary>
    /// The skill to assist with catering requirements.
    /// <see href="https://w3id.org/timebank#Catering"></see></summary>
    let Catering = Namespaced_IRI.parse _namespace_name "Catering" |> NamespacedName
    /// <summary>
    /// The skill to assist with cooking in general.
    /// <see href="https://w3id.org/timebank#Cooking"></see></summary>
    let Cooking = Namespaced_IRI.parse _namespace_name "Cooking" |> NamespacedName

    /// <summary>
    /// The skill to assist with washing dishes.
    /// <see href="https://w3id.org/timebank#Dishwashing"></see></summary>
    let Dishwashing =
        Namespaced_IRI.parse _namespace_name "Dishwashing" |> NamespacedName

    /// <summary>
    /// The skill to assist with food preparation like meat cutting, washing of food, etc.
    /// <see href="https://w3id.org/timebank#FoodPreparation"></see></summary>
    let FoodPreparation =
        Namespaced_IRI.parse _namespace_name "FoodPreparation" |> NamespacedName

    /// <summary>
    /// The skill to assist with general cleaning tasks.
    /// <see href="https://w3id.org/timebank#Cleaning"></see></summary>
    let Cleaning = Namespaced_IRI.parse _namespace_name "Cleaning" |> NamespacedName
    /// <summary>
    /// The skill to assist with mowing the grass.
    /// <see href="https://w3id.org/timebank#Mowing"></see></summary>
    let Mowing = Namespaced_IRI.parse _namespace_name "Mowing" |> NamespacedName
    /// <summary>
    /// The skill to assist with pruning shrubs and twigs.
    /// <see href="https://w3id.org/timebank#Pruning"></see></summary>
    let Pruning = Namespaced_IRI.parse _namespace_name "Pruning" |> NamespacedName

    /// <summary>
    /// Difficulties with moving around physically such as having difficulties using toliet, dressing, walking and so on.
    /// <see href="https://w3id.org/timebank#MobilityProblem"></see></summary>
    let MobilityProblem =
        Namespaced_IRI.parse _namespace_name "MobilityProblem" |> NamespacedName

    /// <summary>
    /// Having difficulties seeing objects clearly.
    /// <see href="https://w3id.org/timebank#PoorEyesight"></see></summary>
    let PoorEyesight =
        Namespaced_IRI.parse _namespace_name "PoorEyesight" |> NamespacedName

    /// <summary>
    /// Having difficulties hearing voices clearly.
    /// <see href="https://w3id.org/timebank#PoorHearing"></see></summary>
    let PoorHearing =
        Namespaced_IRI.parse _namespace_name "PoorHearing" |> NamespacedName

    /// <summary>
    /// Skins are too sensitive to a wide variety of factors such as weather, pets, stress and dust.
    /// <see href="https://w3id.org/timebank#SensitiveSkin"></see></summary>
    let SensitiveSkin =
        Namespaced_IRI.parse _namespace_name "SensitiveSkin" |> NamespacedName

    /// <summary>
    /// The person has difficulties speaking clearly due to body function problems such as injuries to the brain, mouth or throat.
    /// <see href="https://w3id.org/timebank#SpeakingProblem"></see></summary>
    let SpeakingProblem =
        Namespaced_IRI.parse _namespace_name "SpeakingProblem" |> NamespacedName

    /// <summary>
    /// The skill to assist with processing data computers.
    /// <see href="https://w3id.org/timebank#ComputerProcessing"></see></summary>
    let ComputerProcessing =
        Namespaced_IRI.parse _namespace_name "ComputerProcessing" |> NamespacedName

    /// <summary>
    /// The skill to assist with inventory management.
    /// <see href="https://w3id.org/timebank#InventoryManagement"></see></summary>
    let InventoryManagement =
        Namespaced_IRI.parse _namespace_name "InventoryManagement" |> NamespacedName

    /// <summary>
    /// The skill to perform phone calls.
    /// <see href="https://w3id.org/timebank#PhoneCalls"></see></summary>
    let PhoneCalls = Namespaced_IRI.parse _namespace_name "PhoneCalls" |> NamespacedName

    /// <summary>
    /// The skill to assist with recording notes and entries.
    /// <see href="https://w3id.org/timebank#RecordingNotes"></see></summary>
    let RecordingNotes =
        Namespaced_IRI.parse _namespace_name "RecordingNotes" |> NamespacedName

    /// <summary>
    /// The skill to assist with written work, like writing or reading a letter.
    /// <see href="https://w3id.org/timebank#Writing"></see></summary>
    let Writing = Namespaced_IRI.parse _namespace_name "Writing" |> NamespacedName
    /// <summary>
    /// The skill to provide care for children.
    /// <see href="https://w3id.org/timebank#ChildCare"></see></summary>
    let ChildCare = Namespaced_IRI.parse _namespace_name "ChildCare" |> NamespacedName

    /// <summary>
    /// The skill to provide care and support for the elderly.
    /// <see href="https://w3id.org/timebank#ElderlyCare"></see></summary>
    let ElderlyCare =
        Namespaced_IRI.parse _namespace_name "ElderlyCare" |> NamespacedName

    /// <summary>
    /// The skill to provide care for the mentally ill.
    /// <see href="https://w3id.org/timebank#MentallyIllCare"></see></summary>
    let MentallyIllCare =
        Namespaced_IRI.parse _namespace_name "MentallyIllCare" |> NamespacedName

    /// <summary>
    /// The skill to provide care for the physically disabled.
    /// <see href="https://w3id.org/timebank#PhysicallyDisabledCare"></see></summary>
    let PhysicallyDisabledCare =
        Namespaced_IRI.parse _namespace_name "PhysicallyDisabledCare" |> NamespacedName

    /// <summary>
    /// The skill to provide care for sick people.
    /// <see href="https://w3id.org/timebank#SickCare"></see></summary>
    let SickCare = Namespaced_IRI.parse _namespace_name "SickCare" |> NamespacedName
    /// <summary>
    /// Specialized in knitting clothes.
    /// <see href="https://w3id.org/timebank#Knitting"></see></summary>
    let Knitting = Namespaced_IRI.parse _namespace_name "Knitting" |> NamespacedName
    /// <summary>
    /// Specialized in sewing clothes.
    /// <see href="https://w3id.org/timebank#Sewing"></see></summary>
    let Sewing = Namespaced_IRI.parse _namespace_name "Sewing" |> NamespacedName
    /// <summary>
    /// Specialized in providing tailoring services.
    /// <see href="https://w3id.org/timebank#Tailoring"></see></summary>
    let Tailoring = Namespaced_IRI.parse _namespace_name "Tailoring" |> NamespacedName
    /// <summary>
    /// Allergy to eggs.
    /// <see href="https://w3id.org/timebank#EggAllergy"></see></summary>
    let EggAllergy = Namespaced_IRI.parse _namespace_name "EggAllergy" |> NamespacedName

    /// <summary>
    /// Allergies to grains with gluten such as wheat, barley, rye, and oats.
    /// <see href="https://w3id.org/timebank#GlutenAllergy"></see></summary>
    let GlutenAllergy =
        Namespaced_IRI.parse _namespace_name "GlutenAllergy" |> NamespacedName

    /// <summary>
    /// Allergy to milk.
    /// <see href="https://w3id.org/timebank#MilkAllergy"></see></summary>
    let MilkAllergy =
        Namespaced_IRI.parse _namespace_name "MilkAllergy" |> NamespacedName

    /// <summary>
    /// Allergy to nuts such as almonds, walnuts, pecans, and peanuts.
    /// <see href="https://w3id.org/timebank#NutsAllergy"></see></summary>
    let NutsAllergy =
        Namespaced_IRI.parse _namespace_name "NutsAllergy" |> NamespacedName

    /// <summary>
    /// Allergy to any kind of seafood.
    /// <see href="https://w3id.org/timebank#SeafoodAllergy"></see></summary>
    let SeafoodAllergy =
        Namespaced_IRI.parse _namespace_name "SeafoodAllergy" |> NamespacedName

    /// <summary>
    /// Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.
    /// <see href="https://w3id.org/timebank#isSubPartOf"></see></summary>
    let isSubPartOf =
        Namespaced_IRI.parse _namespace_name "isSubPartOf" |> NamespacedName

    /// <summary>
    /// An address part that describes the location of a specific request.
    /// <see href="https://w3id.org/timebank#hasAddressPart"></see></summary>
    let hasAddressPart =
        Namespaced_IRI.parse _namespace_name "hasAddressPart" |> NamespacedName

    /// <summary>
    /// An address part indicates part of an address like region, city, etc. If two places share the same address part, they also share the same environmental factors.
    /// <see href="https://w3id.org/timebank#AddressPart"></see></summary>
    let AddressPart =
        Namespaced_IRI.parse _namespace_name "AddressPart" |> NamespacedName

    /// <summary>
    /// Describes any revelant information regarding the accessibility of a location of a request.
    /// <see href="https://w3id.org/timebank#Accessibility"></see></summary>
    let Accessibility =
        Namespaced_IRI.parse _namespace_name "Accessibility" |> NamespacedName

    /// <summary>
    /// The environment describes relevant environmental factors of a request.
    /// <see href="https://w3id.org/timebank#Environment"></see></summary>
    let Environment =
        Namespaced_IRI.parse _namespace_name "Environment" |> NamespacedName

    /// <summary>
    /// Availability of specific supplies to complete a task.
    /// <see href="https://w3id.org/timebank#Supplies"></see></summary>
    let Supplies = Namespaced_IRI.parse _namespace_name "Supplies" |> NamespacedName
    /// <summary>
    /// The level can be low, medium, or high.
    /// <see href="https://w3id.org/timebank#Level"></see></summary>
    let Level = Namespaced_IRI.parse _namespace_name "Level" |> NamespacedName
    /// <summary>
    /// A request for help from a Timebank user.
    /// <see href="https://w3id.org/timebank#Request"></see></summary>
    let Request = Namespaced_IRI.parse _namespace_name "Request" |> NamespacedName
    /// <summary>
    /// Limitations can be anything which prevents or limits the extent to which a user can help somebody else.
    /// <see href="https://w3id.org/timebank#Limitation"></see></summary>
    let Limitation = Namespaced_IRI.parse _namespace_name "Limitation" |> NamespacedName
    /// <summary>
    /// The status of a request.
    /// <see href="https://w3id.org/timebank#Status"></see></summary>
    let Status = Namespaced_IRI.parse _namespace_name "Status" |> NamespacedName
    /// <summary>
    /// Skills define the capabilities of a user. Users and Timebank requests can be associated to a certain skill (or multiple skills) to facilitate the matching of helper and requester.
    /// <see href="https://w3id.org/timebank#Skill"></see></summary>
    let Skill = Namespaced_IRI.parse _namespace_name "Skill" |> NamespacedName
    /// <summary>
    /// The skill to do carpenting.
    /// <see href="https://w3id.org/timebank#Carpeting"></see></summary>
    let Carpeting = Namespaced_IRI.parse _namespace_name "Carpeting" |> NamespacedName

    /// <summary>
    /// The skill to Carve items out of wood.
    /// <see href="https://w3id.org/timebank#WoodCarving"></see></summary>
    let WoodCarving =
        Namespaced_IRI.parse _namespace_name "WoodCarving" |> NamespacedName

    /// <summary>
    /// Indicates that cats might be present.
    /// <see href="https://w3id.org/timebank#Cats"></see></summary>
    let Cats = Namespaced_IRI.parse _namespace_name "Cats" |> NamespacedName
    /// <summary>
    /// Indicates that pets might be present.
    /// <see href="https://w3id.org/timebank#Pets"></see></summary>
    let Pets = Namespaced_IRI.parse _namespace_name "Pets" |> NamespacedName

    /// <summary>
    /// The skill to assist with washing clothes.
    /// <see href="https://w3id.org/timebank#ClothesWashing"></see></summary>
    let ClothesWashing =
        Namespaced_IRI.parse _namespace_name "ClothesWashing" |> NamespacedName

    /// <summary>
    /// The skill to assist with mopping floors, etc.
    /// <see href="https://w3id.org/timebank#Mopping"></see></summary>
    let Mopping = Namespaced_IRI.parse _namespace_name "Mopping" |> NamespacedName
    /// <summary>
    /// Indicates that dogs might be present.
    /// <see href="https://w3id.org/timebank#Dogs"></see></summary>
    let Dogs = Namespaced_IRI.parse _namespace_name "Dogs" |> NamespacedName

    /// <summary>
    /// Experience in driving cars.
    /// <see href="https://w3id.org/timebank#DrivingCars"></see></summary>
    let DrivingCars =
        Namespaced_IRI.parse _namespace_name "DrivingCars" |> NamespacedName

    /// <summary>
    /// Experience in driving light vehicles.
    /// <see href="https://w3id.org/timebank#DrivingLightVehicles"></see></summary>
    let DrivingLightVehicles =
        Namespaced_IRI.parse _namespace_name "DrivingLightVehicles" |> NamespacedName

    /// <summary>
    /// Experience in driving vans.
    /// <see href="https://w3id.org/timebank#DrivingVans"></see></summary>
    let DrivingVans =
        Namespaced_IRI.parse _namespace_name "DrivingVans" |> NamespacedName

    /// <summary>
    /// Experience in driving heavy vehicles.
    /// <see href="https://w3id.org/timebank#DrivingHeavyVehicles"></see></summary>
    let DrivingHeavyVehicles =
        Namespaced_IRI.parse _namespace_name "DrivingHeavyVehicles" |> NamespacedName

    /// <summary>
    /// Electric outlet available.
    /// <see href="https://w3id.org/timebank#Electricity"></see></summary>
    let Electricity =
        Namespaced_IRI.parse _namespace_name "Electricity" |> NamespacedName

    /// <summary>
    /// A user of the Timebank.
    /// <see href="https://w3id.org/timebank#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName
    /// <summary>
    /// Fear of cats.
    /// <see href="https://w3id.org/timebank#FearOfCats"></see></summary>
    let FearOfCats = Namespaced_IRI.parse _namespace_name "FearOfCats" |> NamespacedName
    /// <summary>
    /// Fear of dogs.
    /// <see href="https://w3id.org/timebank#FearOfDogs"></see></summary>
    let FearOfDogs = Namespaced_IRI.parse _namespace_name "FearOfDogs" |> NamespacedName
    /// <summary>
    /// The skill to help buying groceries.
    /// <see href="https://w3id.org/timebank#Groceries"></see></summary>
    let Groceries = Namespaced_IRI.parse _namespace_name "Groceries" |> NamespacedName

    /// <summary>
    /// The skill to assist in buying things online.
    /// <see href="https://w3id.org/timebank#OnlineShopping"></see></summary>
    let OnlineShopping =
        Namespaced_IRI.parse _namespace_name "OnlineShopping" |> NamespacedName

    /// <summary>
    /// Internet is available.
    /// <see href="https://w3id.org/timebank#Internet"></see></summary>
    let Internet = Namespaced_IRI.parse _namespace_name "Internet" |> NamespacedName
    /// <summary>
    /// Used if a Limitation has a high severity or a Skill is on a high level.
    /// <see href="https://w3id.org/timebank#LevelHigh"></see></summary>
    let LevelHigh = Namespaced_IRI.parse _namespace_name "LevelHigh" |> NamespacedName
    /// <summary>
    /// Used if a Limitation only has a low severity or a Skill is on a low level.
    /// <see href="https://w3id.org/timebank#LevelLow"></see></summary>
    let LevelLow = Namespaced_IRI.parse _namespace_name "LevelLow" |> NamespacedName

    /// <summary>
    /// Used if a Limitation has a medium severity or a Skill is on a medium level
    /// <see href="https://w3id.org/timebank#LevelMedium"></see></summary>
    let LevelMedium =
        Namespaced_IRI.parse _namespace_name "LevelMedium" |> NamespacedName

    /// <summary>
    /// The place is difficult to access during rainfall.
    /// <see href="https://w3id.org/timebank#LimitedAccessibilityRain"></see></summary>
    let LimitedAccessibilityRain =
        Namespaced_IRI.parse _namespace_name "LimitedAccessibilityRain" |> NamespacedName

    /// <summary>
    /// The place is difficult to access during snowfall.
    /// <see href="https://w3id.org/timebank#LimitedAccessibilitySnow"></see></summary>
    let LimitedAccessibilitySnow =
        Namespaced_IRI.parse _namespace_name "LimitedAccessibilitySnow" |> NamespacedName

    /// <summary>
    /// The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.
    /// <see href="https://w3id.org/timebank#hasAccreditedDuration"></see></summary>
    let hasAccreditedDuration =
        Namespaced_IRI.parse _namespace_name "hasAccreditedDuration" |> NamespacedName

    /// <summary>
    /// Every request can have at most one status assigned to it.
    /// <see href="https://w3id.org/timebank#hasStatus"></see></summary>
    let hasStatus = Namespaced_IRI.parse _namespace_name "hasStatus" |> NamespacedName

    /// <summary>
    /// Indicates that the request has the specific originator.
    /// <see href="https://w3id.org/timebank#hasOriginator"></see></summary>
    let hasOriginator =
        Namespaced_IRI.parse _namespace_name "hasOriginator" |> NamespacedName

    /// <summary>
    /// The rating given by the originator of a request to the assigned helper for completing the specific request.
    /// <see href="https://w3id.org/timebank#rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName

    /// <summary>
    /// Indicates that a request is assigned to a helper but not yet completed.
    /// <see href="https://w3id.org/timebank#StatusAssigned"></see></summary>
    let StatusAssigned =
        Namespaced_IRI.parse _namespace_name "StatusAssigned" |> NamespacedName

    /// <summary>
    /// Indicates that a request is cancelled and no helper is needed anymore.
    /// <see href="https://w3id.org/timebank#StatusCancelled"></see></summary>
    let StatusCancelled =
        Namespaced_IRI.parse _namespace_name "StatusCancelled" |> NamespacedName

    /// <summary>
    /// Indicates that a request is closed and that no helper is needed anymore.
    /// <see href="https://w3id.org/timebank#StatusClosed"></see></summary>
    let StatusClosed =
        Namespaced_IRI.parse _namespace_name "StatusClosed" |> NamespacedName

    /// <summary>
    /// Indicates that a request is open and no helper is assigned to it.
    /// <see href="https://w3id.org/timebank#StatusOpen"></see></summary>
    let StatusOpen = Namespaced_IRI.parse _namespace_name "StatusOpen" |> NamespacedName
    /// <summary>
    /// Tools can be provided.
    /// <see href="https://w3id.org/timebank#Tools"></see></summary>
    let Tools = Namespaced_IRI.parse _namespace_name "Tools" |> NamespacedName

    /// <summary>
    /// Indicates the current time-balance of a Timebank user.
    /// <see href="https://w3id.org/timebank#hasTimeBalance"></see></summary>
    let hasTimeBalance =
        Namespaced_IRI.parse _namespace_name "hasTimeBalance" |> NamespacedName

    /// <summary>
    /// Water outlet is available.
    /// <see href="https://w3id.org/timebank#Water"></see></summary>
    let Water = Namespaced_IRI.parse _namespace_name "Water" |> NamespacedName
    /// <summary>
    /// Indicates that a user who is willing to help accepted the request.
    /// <see href="https://w3id.org/timebank#accepts"></see></summary>
    let accepts = Namespaced_IRI.parse _namespace_name "accepts" |> NamespacedName

    /// <summary>
    /// Indicates that a request is accepted by a user who is willing to help completing the request.
    /// <see href="https://w3id.org/timebank#isAcceptedBy"></see></summary>
    let isAcceptedBy =
        Namespaced_IRI.parse _namespace_name "isAcceptedBy" |> NamespacedName

    /// <summary>
    /// Indicates that a time-interval is repeating until this time and date.
    /// <see href="https://w3id.org/timebank#endsRepeatingOn"></see></summary>
    let endsRepeatingOn =
        Namespaced_IRI.parse _namespace_name "endsRepeatingOn" |> NamespacedName

    /// <summary>
    /// Indicates that a specific time and date marks the end of a repetition of a time-interval.
    /// <see href="https://w3id.org/timebank#isRepeatingEndpointOf"></see></summary>
    let isRepeatingEndpointOf =
        Namespaced_IRI.parse _namespace_name "isRepeatingEndpointOf" |> NamespacedName

    /// <summary>
    /// This property is used to describe that a request exludes helpers having a certain limitation.
    /// <see href="https://w3id.org/timebank#excludesUserByLimitation"></see></summary>
    let excludesUserByLimitation =
        Namespaced_IRI.parse _namespace_name "excludesUserByLimitation" |> NamespacedName

    /// <summary>
    /// This property is used to describe that a certain limitation excludes certain helpers from the request.
    /// <see href="https://w3id.org/timebank#excludesUserFrom"></see></summary>
    let excludesUserFrom =
        Namespaced_IRI.parse _namespace_name "excludesUserFrom" |> NamespacedName

    /// <summary>
    /// The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.
    /// <see href="https://w3id.org/timebank#isAccreditedTo"></see></summary>
    let isAccreditedTo =
        Namespaced_IRI.parse _namespace_name "isAccreditedTo" |> NamespacedName

    /// <summary>
    /// An address part that describes the location of a specific request.
    /// <see href="https://w3id.org/timebank#isAdressPartOf"></see></summary>
    let isAdressPartOf =
        Namespaced_IRI.parse _namespace_name "isAdressPartOf" |> NamespacedName

    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#hasEnvironment"></see></summary>
    let hasEnvironment =
        Namespaced_IRI.parse _namespace_name "hasEnvironment" |> NamespacedName

    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#isEnvironmentOf"></see></summary>
    let isEnvironmentOf =
        Namespaced_IRI.parse _namespace_name "isEnvironmentOf" |> NamespacedName

    /// <summary>
    /// The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.
    /// <see href="https://w3id.org/timebank#hasExpectedDuration"></see></summary>
    let hasExpectedDuration =
        Namespaced_IRI.parse _namespace_name "hasExpectedDuration" |> NamespacedName

    /// <summary>
    /// The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.
    /// <see href="https://w3id.org/timebank#isExpectedDurationOf"></see></summary>
    let isExpectedDurationOf =
        Namespaced_IRI.parse _namespace_name "isExpectedDurationOf" |> NamespacedName

    /// <summary>
    /// Indicates that a Timebank user suffers from a certain limitation.
    /// <see href="https://w3id.org/timebank#hasLimitation"></see></summary>
    let hasLimitation =
        Namespaced_IRI.parse _namespace_name "hasLimitation" |> NamespacedName

    /// <summary>
    /// Indicates that a certain limitation applies to the Timebank user.
    /// <see href="https://w3id.org/timebank#isLimitationOf"></see></summary>
    let isLimitationOf =
        Namespaced_IRI.parse _namespace_name "isLimitationOf" |> NamespacedName

    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#hasNotEnvironment"></see></summary>
    let hasNotEnvironment =
        Namespaced_IRI.parse _namespace_name "hasNotEnvironment" |> NamespacedName

    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#isNotEnvironmentOf"></see></summary>
    let isNotEnvironmentOf =
        Namespaced_IRI.parse _namespace_name "isNotEnvironmentOf" |> NamespacedName

    /// <summary>
    /// Indicates that the user is the originator of the request.
    /// <see href="https://w3id.org/timebank#isOriginatorOf"></see></summary>
    let isOriginatorOf =
        Namespaced_IRI.parse _namespace_name "isOriginatorOf" |> NamespacedName

    /// <summary>
    /// Indicates the severity of a limitation.
    /// <see href="https://w3id.org/timebank#hasSeverity"></see></summary>
    let hasSeverity =
        Namespaced_IRI.parse _namespace_name "hasSeverity" |> NamespacedName

    /// <summary>
    /// Indicates the severity of a limitation.
    /// <see href="https://w3id.org/timebank#isSeverityOf"></see></summary>
    let isSeverityOf =
        Namespaced_IRI.parse _namespace_name "isSeverityOf" |> NamespacedName

    /// <summary>
    /// Describes the Skill of a certain Timebank user.
    /// <see href="https://w3id.org/timebank#hasSkill"></see></summary>
    let hasSkill = Namespaced_IRI.parse _namespace_name "hasSkill" |> NamespacedName
    /// <summary>
    /// Describes the Skill of a certain Timebank user.
    /// <see href="https://w3id.org/timebank#isSkillOf"></see></summary>
    let isSkillOf = Namespaced_IRI.parse _namespace_name "isSkillOf" |> NamespacedName

    /// <summary>
    /// Describes the proficiency level of a skill.
    /// <see href="https://w3id.org/timebank#hasSkillLevel"></see></summary>
    let hasSkillLevel =
        Namespaced_IRI.parse _namespace_name "hasSkillLevel" |> NamespacedName

    /// <summary>
    /// Describes the proficiency level of a skill.
    /// <see href="https://w3id.org/timebank#isSkillLevelOf"></see></summary>
    let isSkillLevelOf =
        Namespaced_IRI.parse _namespace_name "isSkillLevelOf" |> NamespacedName

    /// <summary>
    /// Every request can have at most one status assigned to it.
    /// <see href="https://w3id.org/timebank#isStatusOf"></see></summary>
    let isStatusOf = Namespaced_IRI.parse _namespace_name "isStatusOf" |> NamespacedName
    /// <summary>
    /// Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.
    /// <see href="https://w3id.org/timebank#hasSubPart"></see></summary>
    let hasSubPart = Namespaced_IRI.parse _namespace_name "hasSubPart" |> NamespacedName

    /// <summary>
    /// Indicates the current time-balance of a Timebank user.
    /// <see href="https://w3id.org/timebank#isTimeBalanceOf"></see></summary>
    let isTimeBalanceOf =
        Namespaced_IRI.parse _namespace_name "isTimeBalanceOf" |> NamespacedName

    /// <summary>
    /// Indicates the time window in which the request can/should be completed.
    /// <see href="https://w3id.org/timebank#hasTimeWindow"></see></summary>
    let hasTimeWindow =
        Namespaced_IRI.parse _namespace_name "hasTimeWindow" |> NamespacedName

    /// <summary>
    /// Indicates the time window in which the request can/should be completed.
    /// <see href="https://w3id.org/timebank#isTimeWindowOf"></see></summary>
    let isTimeWindowOf =
        Namespaced_IRI.parse _namespace_name "isTimeWindowOf" |> NamespacedName

    /// <summary>
    /// Indicates the time and date when the Timebank request was accepted by the assigned helper.
    /// <see href="https://w3id.org/timebank#isAcceptanceDateOf"></see></summary>
    let isAcceptanceDateOf =
        Namespaced_IRI.parse _namespace_name "isAcceptanceDateOf" |> NamespacedName

    /// <summary>
    /// Indicates the time and date when the Timebank request was accepted by the assigned helper.
    /// <see href="https://w3id.org/timebank#isAcceptedOn"></see></summary>
    let isAcceptedOn =
        Namespaced_IRI.parse _namespace_name "isAcceptedOn" |> NamespacedName

    /// <summary>
    /// Indicates the availability of a Timebank user to act as a helper for a Timebank request.
    /// <see href="https://w3id.org/timebank#isAvailabilityOf"></see></summary>
    let isAvailabilityOf =
        Namespaced_IRI.parse _namespace_name "isAvailabilityOf" |> NamespacedName

    /// <summary>
    /// Indicates the availability of a Timebank user to act as a helper for a Timebank request.
    /// <see href="https://w3id.org/timebank#isAvailableOn"></see></summary>
    let isAvailableOn =
        Namespaced_IRI.parse _namespace_name "isAvailableOn" |> NamespacedName

    /// <summary>
    /// Indicates the time and date when the Timebank request was cancelled.
    /// <see href="https://w3id.org/timebank#isCancellationDateOf"></see></summary>
    let isCancellationDateOf =
        Namespaced_IRI.parse _namespace_name "isCancellationDateOf" |> NamespacedName

    /// <summary>
    /// Indicates the time and date when the Timebank request was cancelled.
    /// <see href="https://w3id.org/timebank#isCancelledOn"></see></summary>
    let isCancelledOn =
        Namespaced_IRI.parse _namespace_name "isCancelledOn" |> NamespacedName

    /// <summary>
    /// Indicates the time and date of the completion of a Timebank request.
    /// <see href="https://w3id.org/timebank#isCompletedOn"></see></summary>
    let isCompletedOn =
        Namespaced_IRI.parse _namespace_name "isCompletedOn" |> NamespacedName

    /// <summary>
    /// Indicates the time and date of the completion of a Timebank request.
    /// <see href="https://w3id.org/timebank#isCompletionDateOf"></see></summary>
    let isCompletionDateOf =
        Namespaced_IRI.parse _namespace_name "isCompletionDateOf" |> NamespacedName

    /// <summary>
    /// Indicates the time and date of the publication of a Timebank request.
    /// <see href="https://w3id.org/timebank#isPublicationDateOf"></see></summary>
    let isPublicationDateOf =
        Namespaced_IRI.parse _namespace_name "isPublicationDateOf" |> NamespacedName

    /// <summary>
    /// Indicates the time and date of the publication of a Timebank request.
    /// <see href="https://w3id.org/timebank#isPublishedOn"></see></summary>
    let isPublishedOn =
        Namespaced_IRI.parse _namespace_name "isPublishedOn" |> NamespacedName

    /// <summary>
    /// Indicates that a time interval repeats on the specified weekdays.
    /// <see href="https://w3id.org/timebank#isRepetitionDayOf"></see></summary>
    let isRepetitionDayOf =
        Namespaced_IRI.parse _namespace_name "isRepetitionDayOf" |> NamespacedName

    /// <summary>
    /// Indicates that a time interval repeats on the specified weekdays.
    /// <see href="https://w3id.org/timebank#repeatsOn"></see></summary>
    let repeatsOn = Namespaced_IRI.parse _namespace_name "repeatsOn" |> NamespacedName

    /// <summary>
    /// The skill associated with a Timebank request.
    /// <see href="https://w3id.org/timebank#isRequiredBy"></see></summary>
    let isRequiredBy =
        Namespaced_IRI.parse _namespace_name "isRequiredBy" |> NamespacedName

    /// <summary>
    /// The skill associated with a Timebank request.
    /// <see href="https://w3id.org/timebank#requiresSkill"></see></summary>
    let requiresSkill =
        Namespaced_IRI.parse _namespace_name "requiresSkill" |> NamespacedName
