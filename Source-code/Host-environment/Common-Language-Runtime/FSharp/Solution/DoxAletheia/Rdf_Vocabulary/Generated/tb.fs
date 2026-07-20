namespace https.w3id.org.timebank.hash

open DoxAletheia

module tb =
    let _namespace_name = "https://w3id.org/timebank#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Fear of animals. This can include dogs, cats, snakes, insects, etc.
    /// <see href="https://w3id.org/timebank#FearOfAnimals"></see></summary>
    let FearOfAnimals = _prefix "FearOfAnimals"
    /// <summary>
    /// Fear of dark places.
    /// <see href="https://w3id.org/timebank#FearOfDark"></see></summary>
    let FearOfDark = _prefix "FearOfDark"
    /// <summary>
    /// Fear or phobia of heights.
    /// <see href="https://w3id.org/timebank#FearOfHeights"></see></summary>
    let FearOfHeights = _prefix "FearOfHeights"
    /// <summary>
    /// A disorder characterized by high blood sugar levels during a long period.
    /// <see href="https://w3id.org/timebank#Diabetes"></see></summary>
    let Diabetes = _prefix "Diabetes"
    /// <summary>
    /// A condition of diseases that negatively affect one's heart such as blood vessel diseases and heart rhythm problems.
    /// <see href="https://w3id.org/timebank#HeartDisease"></see></summary>
    let HeartDisease = _prefix "HeartDisease"
    /// <summary>
    /// The blood pressure is high in a long period.
    /// <see href="https://w3id.org/timebank#Hypertension"></see></summary>
    let Hypertension = _prefix "Hypertension"
    /// <summary>
    /// The blood pressure is low in a long period.
    /// <see href="https://w3id.org/timebank#Hypotension"></see></summary>
    let Hypotension = _prefix "Hypotension"
    /// <summary>
    /// Diseases that causes chronic pain in joints and muscles such as back, shoulder and neck.
    /// <see href="https://w3id.org/timebank#Rheumatism"></see></summary>
    let Rheumatism = _prefix "Rheumatism"
    /// <summary>
    /// It indicates a person once had a storke. A stroke happens when blood flow to the brain is blocked and oxygen for the brain cells is insufficient, which could leads to cell death.
    /// <see href="https://w3id.org/timebank#StrokeHistory"></see></summary>
    let StrokeHistory = _prefix "StrokeHistory"
    /// <summary>
    /// Skills to provide particular services which requires some sort of education or training.
    /// <see href="https://w3id.org/timebank#Advice"></see></summary>
    let Advice = _prefix "Advice"
    /// <summary>
    /// Crafting skills.
    /// <see href="https://w3id.org/timebank#Crafting"></see></summary>
    let Crafting = _prefix "Crafting"
    /// <summary>
    /// The skill to provide services related to food products.
    /// <see href="https://w3id.org/timebank#FoodService"></see></summary>
    let FoodService = _prefix "FoodService"
    /// <summary>
    /// The skill to help with maintenance of equipment.
    /// <see href="https://w3id.org/timebank#Maintenance"></see></summary>
    let Maintenance = _prefix "Maintenance"
    /// <summary>
    /// The skill to provide help with office related work.
    /// <see href="https://w3id.org/timebank#OfficeWork"></see></summary>
    let OfficeWork = _prefix "OfficeWork"
    /// <summary>
    /// The skill to provide care for people.
    /// <see href="https://w3id.org/timebank#PeopleCare"></see></summary>
    let PeopleCare = _prefix "PeopleCare"
    /// <summary>
    /// Personal services which include hygiene and daily care.
    /// <see href="https://w3id.org/timebank#PersonalService"></see></summary>
    let PersonalService = _prefix "PersonalService"
    /// <summary>
    /// The skill to provide services related to recreation.
    /// <see href="https://w3id.org/timebank#Recreation"></see></summary>
    let Recreation = _prefix "Recreation"
    /// <summary>
    /// The Skill to repair equipment and facilities.
    /// <see href="https://w3id.org/timebank#Repair"></see></summary>
    let Repair = _prefix "Repair"
    /// <summary>
    /// The skill to help with selling and buying products.
    /// <see href="https://w3id.org/timebank#SalesService"></see></summary>
    let SalesService = _prefix "SalesService"
    /// <summary>
    /// The skill to provide services related to transportation.
    /// <see href="https://w3id.org/timebank#Transportation"></see></summary>
    let Transportation = _prefix "Transportation"
    /// <summary>
    /// The skill to assist someone with dressing.
    /// <see href="https://w3id.org/timebank#DressingAssistance"></see></summary>
    let DressingAssistance = _prefix "DressingAssistance"
    /// <summary>
    /// Ability to cut someone else's hair.
    /// <see href="https://w3id.org/timebank#HairCutting"></see></summary>
    let HairCutting = _prefix "HairCutting"
    /// <summary>
    /// The skill to assist someone on hygienical matters.
    /// <see href="https://w3id.org/timebank#HygieneAssitance"></see></summary>
    let HygieneAssitance = _prefix "HygieneAssitance"
    /// <summary>
    /// A collection of allergies, which is caused by hypersensitivity of the immune system.
    /// <see href="https://w3id.org/timebank#Allergy"></see></summary>
    let Allergy = _prefix "Allergy"
    /// <summary>
    /// A collection of diseases that are common, especially for elderly people
    /// <see href="https://w3id.org/timebank#CommonDisease"></see></summary>
    let CommonDisease = _prefix "CommonDisease"
    /// <summary>
    /// Disorders that affect the mental states of a person.
    /// <see href="https://w3id.org/timebank#MentalDisorder"></see></summary>
    let MentalDisorder = _prefix "MentalDisorder"
    /// <summary>
    /// This is a collection of physical disorders that negatively affect a person's daily life.
    /// <see href="https://w3id.org/timebank#PhysicalInconvenience"></see></summary>
    let PhysicalInconvenience = _prefix "PhysicalInconvenience"
    /// <summary>
    /// Experience in driving tractors.
    /// <see href="https://w3id.org/timebank#DrivingTractors"></see></summary>
    let DrivingTractors = _prefix "DrivingTractors"
    /// <summary>
    /// Experience in driving with trucks.
    /// <see href="https://w3id.org/timebank#DrivingTrucks"></see></summary>
    let DrivingTrucks = _prefix "DrivingTrucks"
    /// <summary>
    /// Experience in driving with trailers.
    /// <see href="https://w3id.org/timebank#DrivingWithTrailers"></see></summary>
    let DrivingWithTrailers = _prefix "DrivingWithTrailers"
    /// <summary>
    /// A person with cognitive impairment can't think and remember things clearly.
    /// <see href="https://w3id.org/timebank#CognitiveImpairment"></see></summary>
    let CognitiveImpairment = _prefix "CognitiveImpairment"
    /// <summary>
    /// A person with depression has a depressed mood over a long period and may even have thoughts of suicide.
    /// <see href="https://w3id.org/timebank#Depression"></see></summary>
    let Depression = _prefix "Depression"
    /// <summary>
    /// A person with psychotic episode can not tell the difference between the reality and unreality and may have difficulty with social activities in daily life.
    /// <see href="https://w3id.org/timebank#PsychoticEpisode"></see></summary>
    let PsychoticEpisode = _prefix "PsychoticEpisode"
    /// <summary>
    /// Fear of specific objects such as dogs, cats, heights, dark places, and so on.
    /// <see href="https://w3id.org/timebank#SpecificPhobia"></see></summary>
    let SpecificPhobia = _prefix "SpecificPhobia"
    /// <summary>
    /// The person has difficulty in climbing up stairs.
    /// <see href="https://w3id.org/timebank#ClimbingStairsDifficulty"></see></summary>
    let ClimbingStairsDifficulty = _prefix "ClimbingStairsDifficulty"
    /// <summary>
    /// The person has difficulties dressing himself.
    /// <see href="https://w3id.org/timebank#DressingProblem"></see></summary>
    let DressingProblem = _prefix "DressingProblem"
    /// <summary>
    /// The person has difficulties using toilet.
    /// <see href="https://w3id.org/timebank#ToiletUsingProblem"></see></summary>
    let ToiletUsingProblem = _prefix "ToiletUsingProblem"
    /// <summary>
    /// The person has difficulties walking.
    /// <see href="https://w3id.org/timebank#WalkingProblem"></see></summary>
    let WalkingProblem = _prefix "WalkingProblem"
    /// <summary>
    /// An allergy to drugs.
    /// <see href="https://w3id.org/timebank#DrugAllergy"></see></summary>
    let DrugAllergy = _prefix "DrugAllergy"
    /// <summary>
    /// An allergy to something in the environment such as dust mites, pollen, pet hair and cigarette smoke.
    /// <see href="https://w3id.org/timebank#EnvironmentalAllergy"></see></summary>
    let EnvironmentalAllergy = _prefix "EnvironmentalAllergy"
    /// <summary>
    /// An allergy to food such as milk, peanuts, eggs, fish, tree nuts, and fruit.
    /// <see href="https://w3id.org/timebank#FoodAllergy"></see></summary>
    let FoodAllergy = _prefix "FoodAllergy"
    /// <summary>
    /// The ability to act as a dancing companion.
    /// <see href="https://w3id.org/timebank#DancingCompanion"></see></summary>
    let DancingCompanion = _prefix "DancingCompanion"
    /// <summary>
    /// The skill to assist in planning and hosting events.
    /// <see href="https://w3id.org/timebank#EventPlanning"></see></summary>
    let EventPlanning = _prefix "EventPlanning"
    /// <summary>
    /// The skill to participate in board games, card games, etc.
    /// <see href="https://w3id.org/timebank#Games"></see></summary>
    let Games = _prefix "Games"
    /// <summary>
    /// The skill to entertain others by performing music.
    /// <see href="https://w3id.org/timebank#PerformingMusic"></see></summary>
    let PerformingMusic = _prefix "PerformingMusic"
    /// <summary>
    /// The skill to participate in sport activities.
    /// <see href="https://w3id.org/timebank#Sports"></see></summary>
    let Sports = _prefix "Sports"
    /// <summary>
    /// The ability to act as a travel companion.
    /// <see href="https://w3id.org/timebank#TravelCompanion"></see></summary>
    let TravelCompanion = _prefix "TravelCompanion"
    /// <summary>
    /// The skill to assemble items like furniture and other things.
    /// <see href="https://w3id.org/timebank#Assembling"></see></summary>
    let Assembling = _prefix "Assembling"
    /// <summary>
    /// The ability to craft any kind of clothes.
    /// <see href="https://w3id.org/timebank#CraftingClothes"></see></summary>
    let CraftingClothes = _prefix "CraftingClothes"
    /// <summary>
    /// Crafting skill with wood as base material.
    /// <see href="https://w3id.org/timebank#WoodCrafting"></see></summary>
    let WoodCrafting = _prefix "WoodCrafting"
    /// <summary>
    /// The location is accessible by public transport.
    /// <see href="https://w3id.org/timebank#AccessibleByPublicTransport"></see></summary>
    let AccessibleByPublicTransport = _prefix "AccessibleByPublicTransport"
    /// <summary>
    /// A lift/elevator is available.
    /// <see href="https://w3id.org/timebank#Lift"></see></summary>
    let Lift = _prefix "Lift"
    /// <summary>
    /// The person needs to be aware of slippery floor.
    /// <see href="https://w3id.org/timebank#SlipperyFloor"></see></summary>
    let SlipperyFloor = _prefix "SlipperyFloor"
    /// <summary>
    /// The person might have to climb stairs to complete the task.
    /// <see href="https://w3id.org/timebank#Stairs"></see></summary>
    let Stairs = _prefix "Stairs"
    /// <summary>
    /// Transportation necessary to complete the task can be provided.
    /// <see href="https://w3id.org/timebank#TransportationAvailable"></see></summary>
    let TransportationAvailable = _prefix "TransportationAvailable"
    /// <summary>
    /// The person needs equipment (e.g. shoes) suitable for uneven terrain.
    /// <see href="https://w3id.org/timebank#UnevenTerrain"></see></summary>
    let UnevenTerrain = _prefix "UnevenTerrain"
    /// <summary>
    /// The place is difficult to access during bad weather (e.g. snow).
    /// <see href="https://w3id.org/timebank#WeatherConstraint"></see></summary>
    let WeatherConstraint = _prefix "WeatherConstraint"
    /// <summary>
    /// The skill to advice people on psychological matters.
    /// <see href="https://w3id.org/timebank#Counseling"></see></summary>
    let Counseling = _prefix "Counseling"
    /// <summary>
    /// Specialized in providing assistance with financial services. This can include helping with taxes and book keeping.
    /// <see href="https://w3id.org/timebank#FinancialAdvice"></see></summary>
    let FinancialAdvice = _prefix "FinancialAdvice"
    /// <summary>
    /// Specialized in providing legal assistance.
    /// <see href="https://w3id.org/timebank#LegalAdvice"></see></summary>
    let LegalAdvice = _prefix "LegalAdvice"
    /// <summary>
    /// The skill to repair automobiles.
    /// <see href="https://w3id.org/timebank#AutomobileRepair"></see></summary>
    let AutomobileRepair = _prefix "AutomobileRepair"
    /// <summary>
    /// The skill to fix problems with computers.
    /// <see href="https://w3id.org/timebank#ComputerRepair"></see></summary>
    let ComputerRepair = _prefix "ComputerRepair"
    /// <summary>
    /// The skill to repair electronic devices.
    /// <see href="https://w3id.org/timebank#ElectronicRepair"></see></summary>
    let ElectronicRepair = _prefix "ElectronicRepair"
    /// <summary>
    /// The skill to repair household equipment.
    /// <see href="https://w3id.org/timebank#HouseholdEquipmentRepair"></see></summary>
    let HouseholdEquipmentRepair = _prefix "HouseholdEquipmentRepair"
    /// <summary>
    /// Skill to perform plumbing and repairs on pipe installation.
    /// <see href="https://w3id.org/timebank#Plumbing"></see></summary>
    let Plumbing = _prefix "Plumbing"
    /// <summary>
    /// The skill to assist with baking.
    /// <see href="https://w3id.org/timebank#Baking"></see></summary>
    let Baking = _prefix "Baking"
    /// <summary>
    /// The skill to assist with catering requirements.
    /// <see href="https://w3id.org/timebank#Catering"></see></summary>
    let Catering = _prefix "Catering"
    /// <summary>
    /// The skill to assist with cooking in general.
    /// <see href="https://w3id.org/timebank#Cooking"></see></summary>
    let Cooking = _prefix "Cooking"
    /// <summary>
    /// The skill to assist with washing dishes.
    /// <see href="https://w3id.org/timebank#Dishwashing"></see></summary>
    let Dishwashing = _prefix "Dishwashing"
    /// <summary>
    /// The skill to assist with food preparation like meat cutting, washing of food, etc.
    /// <see href="https://w3id.org/timebank#FoodPreparation"></see></summary>
    let FoodPreparation = _prefix "FoodPreparation"
    /// <summary>
    /// The skill to assist with general cleaning tasks.
    /// <see href="https://w3id.org/timebank#Cleaning"></see></summary>
    let Cleaning = _prefix "Cleaning"
    /// <summary>
    /// The skill to assist with mowing the grass.
    /// <see href="https://w3id.org/timebank#Mowing"></see></summary>
    let Mowing = _prefix "Mowing"
    /// <summary>
    /// The skill to assist with pruning shrubs and twigs.
    /// <see href="https://w3id.org/timebank#Pruning"></see></summary>
    let Pruning = _prefix "Pruning"
    /// <summary>
    /// Difficulties with moving around physically such as having difficulties using toliet, dressing, walking and so on.
    /// <see href="https://w3id.org/timebank#MobilityProblem"></see></summary>
    let MobilityProblem = _prefix "MobilityProblem"
    /// <summary>
    /// Having difficulties seeing objects clearly.
    /// <see href="https://w3id.org/timebank#PoorEyesight"></see></summary>
    let PoorEyesight = _prefix "PoorEyesight"
    /// <summary>
    /// Having difficulties hearing voices clearly.
    /// <see href="https://w3id.org/timebank#PoorHearing"></see></summary>
    let PoorHearing = _prefix "PoorHearing"
    /// <summary>
    /// Skins are too sensitive to a wide variety of factors such as weather, pets, stress and dust.
    /// <see href="https://w3id.org/timebank#SensitiveSkin"></see></summary>
    let SensitiveSkin = _prefix "SensitiveSkin"
    /// <summary>
    /// The person has difficulties speaking clearly due to body function problems such as injuries to the brain, mouth or throat.
    /// <see href="https://w3id.org/timebank#SpeakingProblem"></see></summary>
    let SpeakingProblem = _prefix "SpeakingProblem"
    /// <summary>
    /// The skill to assist with processing data computers.
    /// <see href="https://w3id.org/timebank#ComputerProcessing"></see></summary>
    let ComputerProcessing = _prefix "ComputerProcessing"
    /// <summary>
    /// The skill to assist with inventory management.
    /// <see href="https://w3id.org/timebank#InventoryManagement"></see></summary>
    let InventoryManagement = _prefix "InventoryManagement"
    /// <summary>
    /// The skill to perform phone calls.
    /// <see href="https://w3id.org/timebank#PhoneCalls"></see></summary>
    let PhoneCalls = _prefix "PhoneCalls"
    /// <summary>
    /// The skill to assist with recording notes and entries.
    /// <see href="https://w3id.org/timebank#RecordingNotes"></see></summary>
    let RecordingNotes = _prefix "RecordingNotes"
    /// <summary>
    /// The skill to assist with written work, like writing or reading a letter.
    /// <see href="https://w3id.org/timebank#Writing"></see></summary>
    let Writing = _prefix "Writing"
    /// <summary>
    /// The skill to provide care for children.
    /// <see href="https://w3id.org/timebank#ChildCare"></see></summary>
    let ChildCare = _prefix "ChildCare"
    /// <summary>
    /// The skill to provide care and support for the elderly.
    /// <see href="https://w3id.org/timebank#ElderlyCare"></see></summary>
    let ElderlyCare = _prefix "ElderlyCare"
    /// <summary>
    /// The skill to provide care for the mentally ill.
    /// <see href="https://w3id.org/timebank#MentallyIllCare"></see></summary>
    let MentallyIllCare = _prefix "MentallyIllCare"
    /// <summary>
    /// The skill to provide care for the physically disabled.
    /// <see href="https://w3id.org/timebank#PhysicallyDisabledCare"></see></summary>
    let PhysicallyDisabledCare = _prefix "PhysicallyDisabledCare"
    /// <summary>
    /// The skill to provide care for sick people.
    /// <see href="https://w3id.org/timebank#SickCare"></see></summary>
    let SickCare = _prefix "SickCare"
    /// <summary>
    /// Specialized in knitting clothes.
    /// <see href="https://w3id.org/timebank#Knitting"></see></summary>
    let Knitting = _prefix "Knitting"
    /// <summary>
    /// Specialized in sewing clothes.
    /// <see href="https://w3id.org/timebank#Sewing"></see></summary>
    let Sewing = _prefix "Sewing"
    /// <summary>
    /// Specialized in providing tailoring services.
    /// <see href="https://w3id.org/timebank#Tailoring"></see></summary>
    let Tailoring = _prefix "Tailoring"
    /// <summary>
    /// Allergy to eggs.
    /// <see href="https://w3id.org/timebank#EggAllergy"></see></summary>
    let EggAllergy = _prefix "EggAllergy"
    /// <summary>
    /// Allergies to grains with gluten such as wheat, barley, rye, and oats.
    /// <see href="https://w3id.org/timebank#GlutenAllergy"></see></summary>
    let GlutenAllergy = _prefix "GlutenAllergy"
    /// <summary>
    /// Allergy to milk.
    /// <see href="https://w3id.org/timebank#MilkAllergy"></see></summary>
    let MilkAllergy = _prefix "MilkAllergy"
    /// <summary>
    /// Allergy to nuts such as almonds, walnuts, pecans, and peanuts.
    /// <see href="https://w3id.org/timebank#NutsAllergy"></see></summary>
    let NutsAllergy = _prefix "NutsAllergy"
    /// <summary>
    /// Allergy to any kind of seafood.
    /// <see href="https://w3id.org/timebank#SeafoodAllergy"></see></summary>
    let SeafoodAllergy = _prefix "SeafoodAllergy"
    /// <summary>
    /// Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.
    /// <see href="https://w3id.org/timebank#isSubPartOf"></see></summary>
    let isSubPartOf = _prefix "isSubPartOf"
    /// <summary>
    /// An address part that describes the location of a specific request.
    /// <see href="https://w3id.org/timebank#hasAddressPart"></see></summary>
    let hasAddressPart = _prefix "hasAddressPart"
    /// <summary>
    /// An address part indicates part of an address like region, city, etc. If two places share the same address part, they also share the same environmental factors.
    /// <see href="https://w3id.org/timebank#AddressPart"></see></summary>
    let AddressPart = _prefix "AddressPart"
    /// <summary>
    /// Describes any revelant information regarding the accessibility of a location of a request.
    /// <see href="https://w3id.org/timebank#Accessibility"></see></summary>
    let Accessibility = _prefix "Accessibility"
    /// <summary>
    /// The environment describes relevant environmental factors of a request.
    /// <see href="https://w3id.org/timebank#Environment"></see></summary>
    let Environment = _prefix "Environment"
    /// <summary>
    /// Availability of specific supplies to complete a task.
    /// <see href="https://w3id.org/timebank#Supplies"></see></summary>
    let Supplies = _prefix "Supplies"
    /// <summary>
    /// The level can be low, medium, or high.
    /// <see href="https://w3id.org/timebank#Level"></see></summary>
    let Level = _prefix "Level"
    /// <summary>
    /// A request for help from a Timebank user.
    /// <see href="https://w3id.org/timebank#Request"></see></summary>
    let Request = _prefix "Request"
    /// <summary>
    /// Limitations can be anything which prevents or limits the extent to which a user can help somebody else.
    /// <see href="https://w3id.org/timebank#Limitation"></see></summary>
    let Limitation = _prefix "Limitation"
    /// <summary>
    /// The status of a request.
    /// <see href="https://w3id.org/timebank#Status"></see></summary>
    let Status = _prefix "Status"
    /// <summary>
    /// Skills define the capabilities of a user. Users and Timebank requests can be associated to a certain skill (or multiple skills) to facilitate the matching of helper and requester.
    /// <see href="https://w3id.org/timebank#Skill"></see></summary>
    let Skill = _prefix "Skill"
    /// <summary>
    /// The skill to do carpenting.
    /// <see href="https://w3id.org/timebank#Carpeting"></see></summary>
    let Carpeting = _prefix "Carpeting"
    /// <summary>
    /// The skill to Carve items out of wood.
    /// <see href="https://w3id.org/timebank#WoodCarving"></see></summary>
    let WoodCarving = _prefix "WoodCarving"
    /// <summary>
    /// Indicates that cats might be present.
    /// <see href="https://w3id.org/timebank#Cats"></see></summary>
    let Cats = _prefix "Cats"
    /// <summary>
    /// Indicates that pets might be present.
    /// <see href="https://w3id.org/timebank#Pets"></see></summary>
    let Pets = _prefix "Pets"
    /// <summary>
    /// The skill to assist with washing clothes.
    /// <see href="https://w3id.org/timebank#ClothesWashing"></see></summary>
    let ClothesWashing = _prefix "ClothesWashing"
    /// <summary>
    /// The skill to assist with mopping floors, etc.
    /// <see href="https://w3id.org/timebank#Mopping"></see></summary>
    let Mopping = _prefix "Mopping"
    /// <summary>
    /// Indicates that dogs might be present.
    /// <see href="https://w3id.org/timebank#Dogs"></see></summary>
    let Dogs = _prefix "Dogs"
    /// <summary>
    /// Experience in driving cars.
    /// <see href="https://w3id.org/timebank#DrivingCars"></see></summary>
    let DrivingCars = _prefix "DrivingCars"
    /// <summary>
    /// Experience in driving light vehicles.
    /// <see href="https://w3id.org/timebank#DrivingLightVehicles"></see></summary>
    let DrivingLightVehicles = _prefix "DrivingLightVehicles"
    /// <summary>
    /// Experience in driving vans.
    /// <see href="https://w3id.org/timebank#DrivingVans"></see></summary>
    let DrivingVans = _prefix "DrivingVans"
    /// <summary>
    /// Experience in driving heavy vehicles.
    /// <see href="https://w3id.org/timebank#DrivingHeavyVehicles"></see></summary>
    let DrivingHeavyVehicles = _prefix "DrivingHeavyVehicles"
    /// <summary>
    /// Electric outlet available.
    /// <see href="https://w3id.org/timebank#Electricity"></see></summary>
    let Electricity = _prefix "Electricity"
    /// <summary>
    /// A user of the Timebank.
    /// <see href="https://w3id.org/timebank#User"></see></summary>
    let User = _prefix "User"
    /// <summary>
    /// Fear of cats.
    /// <see href="https://w3id.org/timebank#FearOfCats"></see></summary>
    let FearOfCats = _prefix "FearOfCats"
    /// <summary>
    /// Fear of dogs.
    /// <see href="https://w3id.org/timebank#FearOfDogs"></see></summary>
    let FearOfDogs = _prefix "FearOfDogs"
    /// <summary>
    /// The skill to help buying groceries.
    /// <see href="https://w3id.org/timebank#Groceries"></see></summary>
    let Groceries = _prefix "Groceries"
    /// <summary>
    /// The skill to assist in buying things online.
    /// <see href="https://w3id.org/timebank#OnlineShopping"></see></summary>
    let OnlineShopping = _prefix "OnlineShopping"
    /// <summary>
    /// Internet is available.
    /// <see href="https://w3id.org/timebank#Internet"></see></summary>
    let Internet = _prefix "Internet"
    /// <summary>
    /// Used if a Limitation has a high severity or a Skill is on a high level.
    /// <see href="https://w3id.org/timebank#LevelHigh"></see></summary>
    let LevelHigh = _prefix "LevelHigh"
    /// <summary>
    /// Used if a Limitation only has a low severity or a Skill is on a low level.
    /// <see href="https://w3id.org/timebank#LevelLow"></see></summary>
    let LevelLow = _prefix "LevelLow"
    /// <summary>
    /// Used if a Limitation has a medium severity or a Skill is on a medium level
    /// <see href="https://w3id.org/timebank#LevelMedium"></see></summary>
    let LevelMedium = _prefix "LevelMedium"
    /// <summary>
    /// The place is difficult to access during rainfall.
    /// <see href="https://w3id.org/timebank#LimitedAccessibilityRain"></see></summary>
    let LimitedAccessibilityRain = _prefix "LimitedAccessibilityRain"
    /// <summary>
    /// The place is difficult to access during snowfall.
    /// <see href="https://w3id.org/timebank#LimitedAccessibilitySnow"></see></summary>
    let LimitedAccessibilitySnow = _prefix "LimitedAccessibilitySnow"
    /// <summary>
    /// The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.
    /// <see href="https://w3id.org/timebank#hasAccreditedDuration"></see></summary>
    let hasAccreditedDuration = _prefix "hasAccreditedDuration"
    /// <summary>
    /// Every request can have at most one status assigned to it.
    /// <see href="https://w3id.org/timebank#hasStatus"></see></summary>
    let hasStatus = _prefix "hasStatus"
    /// <summary>
    /// Indicates that the request has the specific originator.
    /// <see href="https://w3id.org/timebank#hasOriginator"></see></summary>
    let hasOriginator = _prefix "hasOriginator"
    /// <summary>
    /// The rating given by the originator of a request to the assigned helper for completing the specific request.
    /// <see href="https://w3id.org/timebank#rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// Indicates that a request is assigned to a helper but not yet completed.
    /// <see href="https://w3id.org/timebank#StatusAssigned"></see></summary>
    let StatusAssigned = _prefix "StatusAssigned"
    /// <summary>
    /// Indicates that a request is cancelled and no helper is needed anymore.
    /// <see href="https://w3id.org/timebank#StatusCancelled"></see></summary>
    let StatusCancelled = _prefix "StatusCancelled"
    /// <summary>
    /// Indicates that a request is closed and that no helper is needed anymore.
    /// <see href="https://w3id.org/timebank#StatusClosed"></see></summary>
    let StatusClosed = _prefix "StatusClosed"
    /// <summary>
    /// Indicates that a request is open and no helper is assigned to it.
    /// <see href="https://w3id.org/timebank#StatusOpen"></see></summary>
    let StatusOpen = _prefix "StatusOpen"
    /// <summary>
    /// Tools can be provided.
    /// <see href="https://w3id.org/timebank#Tools"></see></summary>
    let Tools = _prefix "Tools"
    /// <summary>
    /// Indicates the current time-balance of a Timebank user.
    /// <see href="https://w3id.org/timebank#hasTimeBalance"></see></summary>
    let hasTimeBalance = _prefix "hasTimeBalance"
    /// <summary>
    /// Water outlet is available.
    /// <see href="https://w3id.org/timebank#Water"></see></summary>
    let Water = _prefix "Water"
    /// <summary>
    /// Indicates that a user who is willing to help accepted the request.
    /// <see href="https://w3id.org/timebank#accepts"></see></summary>
    let accepts = _prefix "accepts"
    /// <summary>
    /// Indicates that a request is accepted by a user who is willing to help completing the request.
    /// <see href="https://w3id.org/timebank#isAcceptedBy"></see></summary>
    let isAcceptedBy = _prefix "isAcceptedBy"
    /// <summary>
    /// Indicates that a time-interval is repeating until this time and date.
    /// <see href="https://w3id.org/timebank#endsRepeatingOn"></see></summary>
    let endsRepeatingOn = _prefix "endsRepeatingOn"
    /// <summary>
    /// Indicates that a specific time and date marks the end of a repetition of a time-interval.
    /// <see href="https://w3id.org/timebank#isRepeatingEndpointOf"></see></summary>
    let isRepeatingEndpointOf = _prefix "isRepeatingEndpointOf"
    /// <summary>
    /// This property is used to describe that a request exludes helpers having a certain limitation.
    /// <see href="https://w3id.org/timebank#excludesUserByLimitation"></see></summary>
    let excludesUserByLimitation = _prefix "excludesUserByLimitation"
    /// <summary>
    /// This property is used to describe that a certain limitation excludes certain helpers from the request.
    /// <see href="https://w3id.org/timebank#excludesUserFrom"></see></summary>
    let excludesUserFrom = _prefix "excludesUserFrom"
    /// <summary>
    /// The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.
    /// <see href="https://w3id.org/timebank#isAccreditedTo"></see></summary>
    let isAccreditedTo = _prefix "isAccreditedTo"
    /// <summary>
    /// An address part that describes the location of a specific request.
    /// <see href="https://w3id.org/timebank#isAdressPartOf"></see></summary>
    let isAdressPartOf = _prefix "isAdressPartOf"
    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#hasEnvironment"></see></summary>
    let hasEnvironment = _prefix "hasEnvironment"
    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#isEnvironmentOf"></see></summary>
    let isEnvironmentOf = _prefix "isEnvironmentOf"
    /// <summary>
    /// The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.
    /// <see href="https://w3id.org/timebank#hasExpectedDuration"></see></summary>
    let hasExpectedDuration = _prefix "hasExpectedDuration"
    /// <summary>
    /// The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.
    /// <see href="https://w3id.org/timebank#isExpectedDurationOf"></see></summary>
    let isExpectedDurationOf = _prefix "isExpectedDurationOf"
    /// <summary>
    /// Indicates that a Timebank user suffers from a certain limitation.
    /// <see href="https://w3id.org/timebank#hasLimitation"></see></summary>
    let hasLimitation = _prefix "hasLimitation"
    /// <summary>
    /// Indicates that a certain limitation applies to the Timebank user.
    /// <see href="https://w3id.org/timebank#isLimitationOf"></see></summary>
    let isLimitationOf = _prefix "isLimitationOf"
    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#hasNotEnvironment"></see></summary>
    let hasNotEnvironment = _prefix "hasNotEnvironment"
    /// <summary>
    /// Indicates that a certain Location Specifier has a specific environmental factor.
    /// <see href="https://w3id.org/timebank#isNotEnvironmentOf"></see></summary>
    let isNotEnvironmentOf = _prefix "isNotEnvironmentOf"
    /// <summary>
    /// Indicates that the user is the originator of the request.
    /// <see href="https://w3id.org/timebank#isOriginatorOf"></see></summary>
    let isOriginatorOf = _prefix "isOriginatorOf"
    /// <summary>
    /// Indicates the severity of a limitation.
    /// <see href="https://w3id.org/timebank#hasSeverity"></see></summary>
    let hasSeverity = _prefix "hasSeverity"
    /// <summary>
    /// Indicates the severity of a limitation.
    /// <see href="https://w3id.org/timebank#isSeverityOf"></see></summary>
    let isSeverityOf = _prefix "isSeverityOf"
    /// <summary>
    /// Describes the Skill of a certain Timebank user.
    /// <see href="https://w3id.org/timebank#hasSkill"></see></summary>
    let hasSkill = _prefix "hasSkill"
    /// <summary>
    /// Describes the Skill of a certain Timebank user.
    /// <see href="https://w3id.org/timebank#isSkillOf"></see></summary>
    let isSkillOf = _prefix "isSkillOf"
    /// <summary>
    /// Describes the proficiency level of a skill.
    /// <see href="https://w3id.org/timebank#hasSkillLevel"></see></summary>
    let hasSkillLevel = _prefix "hasSkillLevel"
    /// <summary>
    /// Describes the proficiency level of a skill.
    /// <see href="https://w3id.org/timebank#isSkillLevelOf"></see></summary>
    let isSkillLevelOf = _prefix "isSkillLevelOf"
    /// <summary>
    /// Every request can have at most one status assigned to it.
    /// <see href="https://w3id.org/timebank#isStatusOf"></see></summary>
    let isStatusOf = _prefix "isStatusOf"
    /// <summary>
    /// Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.
    /// <see href="https://w3id.org/timebank#hasSubPart"></see></summary>
    let hasSubPart = _prefix "hasSubPart"
    /// <summary>
    /// Indicates the current time-balance of a Timebank user.
    /// <see href="https://w3id.org/timebank#isTimeBalanceOf"></see></summary>
    let isTimeBalanceOf = _prefix "isTimeBalanceOf"
    /// <summary>
    /// Indicates the time window in which the request can/should be completed.
    /// <see href="https://w3id.org/timebank#hasTimeWindow"></see></summary>
    let hasTimeWindow = _prefix "hasTimeWindow"
    /// <summary>
    /// Indicates the time window in which the request can/should be completed.
    /// <see href="https://w3id.org/timebank#isTimeWindowOf"></see></summary>
    let isTimeWindowOf = _prefix "isTimeWindowOf"
    /// <summary>
    /// Indicates the time and date when the Timebank request was accepted by the assigned helper.
    /// <see href="https://w3id.org/timebank#isAcceptanceDateOf"></see></summary>
    let isAcceptanceDateOf = _prefix "isAcceptanceDateOf"
    /// <summary>
    /// Indicates the time and date when the Timebank request was accepted by the assigned helper.
    /// <see href="https://w3id.org/timebank#isAcceptedOn"></see></summary>
    let isAcceptedOn = _prefix "isAcceptedOn"
    /// <summary>
    /// Indicates the availability of a Timebank user to act as a helper for a Timebank request.
    /// <see href="https://w3id.org/timebank#isAvailabilityOf"></see></summary>
    let isAvailabilityOf = _prefix "isAvailabilityOf"
    /// <summary>
    /// Indicates the availability of a Timebank user to act as a helper for a Timebank request.
    /// <see href="https://w3id.org/timebank#isAvailableOn"></see></summary>
    let isAvailableOn = _prefix "isAvailableOn"
    /// <summary>
    /// Indicates the time and date when the Timebank request was cancelled.
    /// <see href="https://w3id.org/timebank#isCancellationDateOf"></see></summary>
    let isCancellationDateOf = _prefix "isCancellationDateOf"
    /// <summary>
    /// Indicates the time and date when the Timebank request was cancelled.
    /// <see href="https://w3id.org/timebank#isCancelledOn"></see></summary>
    let isCancelledOn = _prefix "isCancelledOn"
    /// <summary>
    /// Indicates the time and date of the completion of a Timebank request.
    /// <see href="https://w3id.org/timebank#isCompletedOn"></see></summary>
    let isCompletedOn = _prefix "isCompletedOn"
    /// <summary>
    /// Indicates the time and date of the completion of a Timebank request.
    /// <see href="https://w3id.org/timebank#isCompletionDateOf"></see></summary>
    let isCompletionDateOf = _prefix "isCompletionDateOf"
    /// <summary>
    /// Indicates the time and date of the publication of a Timebank request.
    /// <see href="https://w3id.org/timebank#isPublicationDateOf"></see></summary>
    let isPublicationDateOf = _prefix "isPublicationDateOf"
    /// <summary>
    /// Indicates the time and date of the publication of a Timebank request.
    /// <see href="https://w3id.org/timebank#isPublishedOn"></see></summary>
    let isPublishedOn = _prefix "isPublishedOn"
    /// <summary>
    /// Indicates that a time interval repeats on the specified weekdays.
    /// <see href="https://w3id.org/timebank#isRepetitionDayOf"></see></summary>
    let isRepetitionDayOf = _prefix "isRepetitionDayOf"
    /// <summary>
    /// Indicates that a time interval repeats on the specified weekdays.
    /// <see href="https://w3id.org/timebank#repeatsOn"></see></summary>
    let repeatsOn = _prefix "repeatsOn"
    /// <summary>
    /// The skill associated with a Timebank request.
    /// <see href="https://w3id.org/timebank#isRequiredBy"></see></summary>
    let isRequiredBy = _prefix "isRequiredBy"
    /// <summary>
    /// The skill associated with a Timebank request.
    /// <see href="https://w3id.org/timebank#requiresSkill"></see></summary>
    let requiresSkill = _prefix "requiresSkill"
