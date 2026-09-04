#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module tb =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/timebank#" "tb"
    /// <summary>
    ///   <para>rdfs:label : Accessibility^^xsd:string</para>
    ///   <para>rdfs:comment : Describes any revelant information regarding the accessibility of a location of a request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Accessibility">tb:Accessibility</a>
    /// </summary>
    let Accessibility = _prefixId.prefix "Accessibility"
    /// <summary>
    ///   <para>rdfs:label : Accessible by Public Transport^^xsd:string</para>
    ///   <para>rdfs:comment : The location is accessible by public transport.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#AccessibleByPublicTransport">tb:AccessibleByPublicTransport</a>
    /// </summary>
    let AccessibleByPublicTransport = _prefixId.prefix "AccessibleByPublicTransport"
    /// <summary>
    ///   <para>rdfs:label : Address Part^^xsd:string</para>
    ///   <para>rdfs:comment : An address part indicates part of an address like region, city, etc. If two places share the same address part, they also share the same environmental factors.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#AddressPart">tb:AddressPart</a>
    /// </summary>
    let AddressPart = _prefixId.prefix "AddressPart"
    /// <summary>
    ///   <para>rdfs:label : Advice^^xsd:string</para>
    ///   <para>rdfs:comment : Skills to provide particular services which requires some sort of education or training.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Advice">tb:Advice</a>
    /// </summary>
    let Advice = _prefixId.prefix "Advice"
    /// <summary>
    ///   <para>rdfs:label : Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of allergies, which is caused by hypersensitivity of the immune system.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Allergy">tb:Allergy</a>
    /// </summary>
    let Allergy = _prefixId.prefix "Allergy"
    /// <summary>
    ///   <para>rdfs:label : Assembling^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assemble items like furniture and other things.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Assembling">tb:Assembling</a>
    /// </summary>
    let Assembling = _prefixId.prefix "Assembling"
    /// <summary>
    ///   <para>rdfs:label : Automobile Repair^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to repair automobiles.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#AutomobileRepair">tb:AutomobileRepair</a>
    /// </summary>
    let AutomobileRepair = _prefixId.prefix "AutomobileRepair"
    /// <summary>
    ///   <para>rdfs:label : Baking^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with baking.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Baking">tb:Baking</a>
    /// </summary>
    let Baking = _prefixId.prefix "Baking"
    /// <summary>
    ///   <para>rdfs:label : Carpenting^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to do carpenting.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Carpeting">tb:Carpeting</a>
    /// </summary>
    let Carpeting = _prefixId.prefix "Carpeting"
    /// <summary>
    ///   <para>rdfs:label : Catering^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with catering requirements.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Catering">tb:Catering</a>
    /// </summary>
    let Catering = _prefixId.prefix "Catering"
    /// <summary>
    ///   <para>rdfs:label : Cats^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that cats might be present.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Cats">tb:Cats</a>
    /// </summary>
    let Cats = _prefixId.prefix "Cats"
    /// <summary>
    ///   <para>rdfs:label : Child Care^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care for children.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ChildCare">tb:ChildCare</a>
    /// </summary>
    let ChildCare = _prefixId.prefix "ChildCare"
    /// <summary>
    ///   <para>rdfs:label : Cleaning^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with general cleaning tasks.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Cleaning">tb:Cleaning</a>
    /// </summary>
    let Cleaning = _prefixId.prefix "Cleaning"
    /// <summary>
    ///   <para>rdfs:label : Difficulty in Climbing Stairs^^xsd:string</para>
    ///   <para>rdfs:comment : The person has difficulty in climbing up stairs.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ClimbingStairsDifficulty">tb:ClimbingStairsDifficulty</a>
    /// </summary>
    let ClimbingStairsDifficulty = _prefixId.prefix "ClimbingStairsDifficulty"
    /// <summary>
    ///   <para>rdfs:label : Clothes Washing^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with washing clothes.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ClothesWashing">tb:ClothesWashing</a>
    /// </summary>
    let ClothesWashing = _prefixId.prefix "ClothesWashing"
    /// <summary>
    ///   <para>rdfs:label : Cognitive Impairment^^xsd:string</para>
    ///   <para>rdfs:comment : A person with cognitive impairment can't think and remember things clearly.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#CognitiveImpairment">tb:CognitiveImpairment</a>
    /// </summary>
    let CognitiveImpairment = _prefixId.prefix "CognitiveImpairment"
    /// <summary>
    ///   <para>rdfs:label : Common Disease^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of diseases that are common, especially for elderly people^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#CommonDisease">tb:CommonDisease</a>
    /// </summary>
    let CommonDisease = _prefixId.prefix "CommonDisease"
    /// <summary>
    ///   <para>rdfs:label : Computer Processing^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with processing data computers.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ComputerProcessing">tb:ComputerProcessing</a>
    /// </summary>
    let ComputerProcessing = _prefixId.prefix "ComputerProcessing"
    /// <summary>
    ///   <para>rdfs:label : Computer Repair^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to fix problems with computers.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ComputerRepair">tb:ComputerRepair</a>
    /// </summary>
    let ComputerRepair = _prefixId.prefix "ComputerRepair"
    /// <summary>
    ///   <para>rdfs:label : Cooking^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with cooking in general.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Cooking">tb:Cooking</a>
    /// </summary>
    let Cooking = _prefixId.prefix "Cooking"
    /// <summary>
    ///   <para>rdfs:label : Counseling^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to advice people on psychological matters.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Counseling">tb:Counseling</a>
    /// </summary>
    let Counseling = _prefixId.prefix "Counseling"
    /// <summary>
    ///   <para>rdfs:label : Crafting^^xsd:string</para>
    ///   <para>rdfs:comment : Crafting skills.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Crafting">tb:Crafting</a>
    /// </summary>
    let Crafting = _prefixId.prefix "Crafting"
    /// <summary>
    ///   <para>rdfs:label : Crafting Clothes^^xsd:string</para>
    ///   <para>rdfs:comment : The ability to craft any kind of clothes.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#CraftingClothes">tb:CraftingClothes</a>
    /// </summary>
    let CraftingClothes = _prefixId.prefix "CraftingClothes"
    /// <summary>
    ///   <para>rdfs:label : Dancing Companion^^xsd:string</para>
    ///   <para>rdfs:comment : The ability to act as a dancing companion.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DancingCompanion">tb:DancingCompanion</a>
    /// </summary>
    let DancingCompanion = _prefixId.prefix "DancingCompanion"
    /// <summary>
    ///   <para>rdfs:comment : A person with depression has a depressed mood over a long period and may even have thoughts of suicide.^^xsd:string</para>
    ///   <para>rdfs:label : Depression^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Depression">tb:Depression</a>
    /// </summary>
    let Depression = _prefixId.prefix "Depression"
    /// <summary>
    ///   <para>rdfs:label : Diabetes Mellitus^^xsd:string</para>
    ///   <para>rdfs:comment : A disorder characterized by high blood sugar levels during a long period.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Diabetes">tb:Diabetes</a>
    /// </summary>
    let Diabetes = _prefixId.prefix "Diabetes"
    /// <summary>
    ///   <para>rdfs:label : Dishwashing^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with washing dishes.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Dishwashing">tb:Dishwashing</a>
    /// </summary>
    let Dishwashing = _prefixId.prefix "Dishwashing"
    /// <summary>
    ///   <para>rdfs:label : Dogs^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that dogs might be present.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Dogs">tb:Dogs</a>
    /// </summary>
    let Dogs = _prefixId.prefix "Dogs"
    /// <summary>
    ///   <para>rdfs:label : Dressing Assistance^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist someone with dressing.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DressingAssistance">tb:DressingAssistance</a>
    /// </summary>
    let DressingAssistance = _prefixId.prefix "DressingAssistance"
    /// <summary>
    ///   <para>rdfs:label : Dressing Problem^^xsd:string</para>
    ///   <para>rdfs:comment : The person has difficulties dressing himself.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DressingProblem">tb:DressingProblem</a>
    /// </summary>
    let DressingProblem = _prefixId.prefix "DressingProblem"
    /// <summary>
    ///   <para>rdfs:label : Driving Cars^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving cars.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingCars">tb:DrivingCars</a>
    /// </summary>
    let DrivingCars = _prefixId.prefix "DrivingCars"
    /// <summary>
    ///   <para>rdfs:label : Driving Heavy Vehicles^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving heavy vehicles.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingHeavyVehicles">tb:DrivingHeavyVehicles</a>
    /// </summary>
    let DrivingHeavyVehicles = _prefixId.prefix "DrivingHeavyVehicles"
    /// <summary>
    ///   <para>rdfs:label : Driving Light Vehicles^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving light vehicles.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingLightVehicles">tb:DrivingLightVehicles</a>
    /// </summary>
    let DrivingLightVehicles = _prefixId.prefix "DrivingLightVehicles"
    /// <summary>
    ///   <para>rdfs:label : Driving Tractors^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving tractors.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingTractors">tb:DrivingTractors</a>
    /// </summary>
    let DrivingTractors = _prefixId.prefix "DrivingTractors"
    /// <summary>
    ///   <para>rdfs:label : Driving Trucks^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving with trucks.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingTrucks">tb:DrivingTrucks</a>
    /// </summary>
    let DrivingTrucks = _prefixId.prefix "DrivingTrucks"
    /// <summary>
    ///   <para>rdfs:label : Driving Vans^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving vans.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingVans">tb:DrivingVans</a>
    /// </summary>
    let DrivingVans = _prefixId.prefix "DrivingVans"
    /// <summary>
    ///   <para>rdfs:label : Driving with Trailers^^xsd:string</para>
    ///   <para>rdfs:comment : Experience in driving with trailers.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrivingWithTrailers">tb:DrivingWithTrailers</a>
    /// </summary>
    let DrivingWithTrailers = _prefixId.prefix "DrivingWithTrailers"
    /// <summary>
    ///   <para>rdfs:label : Drug Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : An allergy to drugs.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#DrugAllergy">tb:DrugAllergy</a>
    /// </summary>
    let DrugAllergy = _prefixId.prefix "DrugAllergy"
    /// <summary>
    ///   <para>rdfs:comment : Allergy to eggs.^^xsd:string</para>
    ///   <para>rdfs:label : Egg Allergy^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#EggAllergy">tb:EggAllergy</a>
    /// </summary>
    let EggAllergy = _prefixId.prefix "EggAllergy"
    /// <summary>
    ///   <para>rdfs:label : Care for Elderly^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care and support for the elderly.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ElderlyCare">tb:ElderlyCare</a>
    /// </summary>
    let ElderlyCare = _prefixId.prefix "ElderlyCare"
    /// <summary>
    ///   <para>rdfs:label : Electricity^^xsd:string</para>
    ///   <para>rdfs:comment : Electric outlet available.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Electricity">tb:Electricity</a>
    /// </summary>
    let Electricity = _prefixId.prefix "Electricity"
    /// <summary>
    ///   <para>rdfs:label : Electronic Repair^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to repair electronic devices.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ElectronicRepair">tb:ElectronicRepair</a>
    /// </summary>
    let ElectronicRepair = _prefixId.prefix "ElectronicRepair"
    /// <summary>
    ///   <para>rdfs:label : Environment^^xsd:string</para>
    ///   <para>rdfs:comment : The environment describes relevant environmental factors of a request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Environment">tb:Environment</a>
    /// </summary>
    let Environment = _prefixId.prefix "Environment"
    /// <summary>
    ///   <para>rdfs:label : Environmental Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : An allergy to something in the environment such as dust mites, pollen, pet hair and cigarette smoke.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#EnvironmentalAllergy">tb:EnvironmentalAllergy</a>
    /// </summary>
    let EnvironmentalAllergy = _prefixId.prefix "EnvironmentalAllergy"
    /// <summary>
    ///   <para>rdfs:label : Event Planning^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist in planning and hosting events.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#EventPlanning">tb:EventPlanning</a>
    /// </summary>
    let EventPlanning = _prefixId.prefix "EventPlanning"
    /// <summary>
    ///   <para>rdfs:label : Fear of Animals^^xsd:string</para>
    ///   <para>rdfs:comment : Fear of animals. This can include dogs, cats, snakes, insects, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FearOfAnimals">tb:FearOfAnimals</a>
    /// </summary>
    let FearOfAnimals = _prefixId.prefix "FearOfAnimals"
    /// <summary>
    ///   <para>rdfs:label : Fear of Cats^^xsd:string</para>
    ///   <para>rdfs:comment : Fear of cats.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FearOfCats">tb:FearOfCats</a>
    /// </summary>
    let FearOfCats = _prefixId.prefix "FearOfCats"
    /// <summary>
    ///   <para>rdfs:label : Fear of Dark^^xsd:string</para>
    ///   <para>rdfs:comment : Fear of dark places.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FearOfDark">tb:FearOfDark</a>
    /// </summary>
    let FearOfDark = _prefixId.prefix "FearOfDark"
    /// <summary>
    ///   <para>rdfs:label : Fear of Dogs^^xsd:string</para>
    ///   <para>rdfs:comment : Fear of dogs.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FearOfDogs">tb:FearOfDogs</a>
    /// </summary>
    let FearOfDogs = _prefixId.prefix "FearOfDogs"
    /// <summary>
    ///   <para>rdfs:label : Fear of Heights^^xsd:string</para>
    ///   <para>rdfs:comment : Fear or phobia of heights.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FearOfHeights">tb:FearOfHeights</a>
    /// </summary>
    let FearOfHeights = _prefixId.prefix "FearOfHeights"
    /// <summary>
    ///   <para>rdfs:label : Financial Advice^^xsd:string</para>
    ///   <para>rdfs:comment : Specialized in providing assistance with financial services. This can include helping with taxes and book keeping.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FinancialAdvice">tb:FinancialAdvice</a>
    /// </summary>
    let FinancialAdvice = _prefixId.prefix "FinancialAdvice"
    /// <summary>
    ///   <para>rdfs:label : Food Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : An allergy to food such as milk, peanuts, eggs, fish, tree nuts, and fruit.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FoodAllergy">tb:FoodAllergy</a>
    /// </summary>
    let FoodAllergy = _prefixId.prefix "FoodAllergy"
    /// <summary>
    ///   <para>rdfs:label : Food Preparation^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with food preparation like meat cutting, washing of food, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FoodPreparation">tb:FoodPreparation</a>
    /// </summary>
    let FoodPreparation = _prefixId.prefix "FoodPreparation"
    /// <summary>
    ///   <para>rdfs:label : Food Service^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide services related to food products.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#FoodService">tb:FoodService</a>
    /// </summary>
    let FoodService = _prefixId.prefix "FoodService"
    /// <summary>
    ///   <para>rdfs:label : Games^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to participate in board games, card games, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Games">tb:Games</a>
    /// </summary>
    let Games = _prefixId.prefix "Games"
    /// <summary>
    ///   <para>rdfs:label : Gluten Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : Allergies to grains with gluten such as wheat, barley, rye, and oats.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#GlutenAllergy">tb:GlutenAllergy</a>
    /// </summary>
    let GlutenAllergy = _prefixId.prefix "GlutenAllergy"
    /// <summary>
    ///   <para>rdfs:label : Groceries^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to help buying groceries.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Groceries">tb:Groceries</a>
    /// </summary>
    let Groceries = _prefixId.prefix "Groceries"
    /// <summary>
    ///   <para>rdfs:label : Hair Cutting^^xsd:string</para>
    ///   <para>rdfs:comment : Ability to cut someone else's hair.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#HairCutting">tb:HairCutting</a>
    /// </summary>
    let HairCutting = _prefixId.prefix "HairCutting"
    /// <summary>
    ///   <para>rdfs:label : Heart Diseases^^xsd:string</para>
    ///   <para>rdfs:comment : A condition of diseases that negatively affect one's heart such as blood vessel diseases and heart rhythm problems.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#HeartDisease">tb:HeartDisease</a>
    /// </summary>
    let HeartDisease = _prefixId.prefix "HeartDisease"
    /// <summary>
    ///   <para>rdfs:label : Houseshold Equipment Repair^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to repair household equipment.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#HouseholdEquipmentRepair">tb:HouseholdEquipmentRepair</a>
    /// </summary>
    let HouseholdEquipmentRepair = _prefixId.prefix "HouseholdEquipmentRepair"
    /// <summary>
    ///   <para>rdfs:label : Hygiene Assitance^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist someone on hygienical matters.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#HygieneAssitance">tb:HygieneAssitance</a>
    /// </summary>
    let HygieneAssitance = _prefixId.prefix "HygieneAssitance"
    /// <summary>
    ///   <para>rdfs:label : Hypertension^^xsd:string</para>
    ///   <para>rdfs:comment : The blood pressure is high in a long period.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Hypertension">tb:Hypertension</a>
    /// </summary>
    let Hypertension = _prefixId.prefix "Hypertension"
    /// <summary>
    ///   <para>rdfs:label : Hypotension^^xsd:string</para>
    ///   <para>rdfs:comment : The blood pressure is low in a long period.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Hypotension">tb:Hypotension</a>
    /// </summary>
    let Hypotension = _prefixId.prefix "Hypotension"
    /// <summary>
    ///   <para>rdfs:label : Internet^^xsd:string</para>
    ///   <para>rdfs:comment : Internet is available.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Internet">tb:Internet</a>
    /// </summary>
    let Internet = _prefixId.prefix "Internet"
    /// <summary>
    ///   <para>rdfs:label : Inventory Management^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with inventory management.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#InventoryManagement">tb:InventoryManagement</a>
    /// </summary>
    let InventoryManagement = _prefixId.prefix "InventoryManagement"
    /// <summary>
    ///   <para>rdfs:label : Knitting^^xsd:string</para>
    ///   <para>rdfs:comment : Specialized in knitting clothes.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Knitting">tb:Knitting</a>
    /// </summary>
    let Knitting = _prefixId.prefix "Knitting"
    /// <summary>
    ///   <para>rdfs:label : Legal Advice^^xsd:string</para>
    ///   <para>rdfs:comment : Specialized in providing legal assistance.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#LegalAdvice">tb:LegalAdvice</a>
    /// </summary>
    let LegalAdvice = _prefixId.prefix "LegalAdvice"
    /// <summary>
    ///   <para>rdfs:label : Level^^xsd:string</para>
    ///   <para>rdfs:comment : The level can be low, medium, or high.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Level">tb:Level</a>
    /// </summary>
    let Level = _prefixId.prefix "Level"
    let LevelHigh = _prefixId.prefix "LevelHigh"
    let LevelLow = _prefixId.prefix "LevelLow"
    let LevelMedium = _prefixId.prefix "LevelMedium"
    /// <summary>
    ///   <para>rdfs:comment : A lift/elevator is available.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Lift">tb:Lift</a>
    /// </summary>
    let Lift = _prefixId.prefix "Lift"
    /// <summary>
    ///   <para>rdfs:label : Limitation^^xsd:string</para>
    ///   <para>rdfs:comment : Limitations can be anything which prevents or limits the extent to which a user can help somebody else.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Limitation">tb:Limitation</a>
    /// </summary>
    let Limitation = _prefixId.prefix "Limitation"
    /// <summary>
    ///   <para>rdfs:label : Limited Accessibility: Rain^^xsd:string</para>
    ///   <para>rdfs:comment : The place is difficult to access during rainfall.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#LimitedAccessibilityRain">tb:LimitedAccessibilityRain</a>
    /// </summary>
    let LimitedAccessibilityRain = _prefixId.prefix "LimitedAccessibilityRain"
    /// <summary>
    ///   <para>rdfs:label : Limited Accessibility: Snow^^xsd:string</para>
    ///   <para>rdfs:comment : The place is difficult to access during snowfall.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#LimitedAccessibilitySnow">tb:LimitedAccessibilitySnow</a>
    /// </summary>
    let LimitedAccessibilitySnow = _prefixId.prefix "LimitedAccessibilitySnow"
    /// <summary>
    ///   <para>rdfs:label : Maintenance^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to help with maintenance of equipment.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Maintenance">tb:Maintenance</a>
    /// </summary>
    let Maintenance = _prefixId.prefix "Maintenance"
    /// <summary>
    ///   <para>rdfs:comment : Disorders that affect the mental states of a person.^^xsd:string</para>
    ///   <para>rdfs:label : Mental Disorder^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#MentalDisorder">tb:MentalDisorder</a>
    /// </summary>
    let MentalDisorder = _prefixId.prefix "MentalDisorder"
    /// <summary>
    ///   <para>rdfs:label : Care Mentally Ill People^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care for the mentally ill.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#MentallyIllCare">tb:MentallyIllCare</a>
    /// </summary>
    let MentallyIllCare = _prefixId.prefix "MentallyIllCare"
    /// <summary>
    ///   <para>rdfs:label : Milk Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : Allergy to milk.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#MilkAllergy">tb:MilkAllergy</a>
    /// </summary>
    let MilkAllergy = _prefixId.prefix "MilkAllergy"
    /// <summary>
    ///   <para>rdfs:comment : Difficulties with moving around physically such as having difficulties using toliet, dressing, walking and so on.^^xsd:string</para>
    ///   <para>rdfs:label : Mobility Problem^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#MobilityProblem">tb:MobilityProblem</a>
    /// </summary>
    let MobilityProblem = _prefixId.prefix "MobilityProblem"
    /// <summary>
    ///   <para>rdfs:label : Mopping^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with mopping floors, etc.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Mopping">tb:Mopping</a>
    /// </summary>
    let Mopping = _prefixId.prefix "Mopping"
    /// <summary>
    ///   <para>rdfs:label : Mowing^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with mowing the grass.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Mowing">tb:Mowing</a>
    /// </summary>
    let Mowing = _prefixId.prefix "Mowing"
    /// <summary>
    ///   <para>rdfs:label : Nuts Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : Allergy to nuts such as almonds, walnuts, pecans, and peanuts.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#NutsAllergy">tb:NutsAllergy</a>
    /// </summary>
    let NutsAllergy = _prefixId.prefix "NutsAllergy"
    /// <summary>
    ///   <para>rdfs:label : Office Work^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide help with office related work.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#OfficeWork">tb:OfficeWork</a>
    /// </summary>
    let OfficeWork = _prefixId.prefix "OfficeWork"
    /// <summary>
    ///   <para>rdfs:label : Online Shopping^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist in buying things online.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#OnlineShopping">tb:OnlineShopping</a>
    /// </summary>
    let OnlineShopping = _prefixId.prefix "OnlineShopping"
    /// <summary>
    ///   <para>rdfs:label : Care for People^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care for people.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PeopleCare">tb:PeopleCare</a>
    /// </summary>
    let PeopleCare = _prefixId.prefix "PeopleCare"
    /// <summary>
    ///   <para>rdfs:label : Performing Music^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to entertain others by performing music.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PerformingMusic">tb:PerformingMusic</a>
    /// </summary>
    let PerformingMusic = _prefixId.prefix "PerformingMusic"
    /// <summary>
    ///   <para>rdfs:label : Personal Service^^xsd:string</para>
    ///   <para>rdfs:comment : Personal services which include hygiene and daily care.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PersonalService">tb:PersonalService</a>
    /// </summary>
    let PersonalService = _prefixId.prefix "PersonalService"
    /// <summary>
    ///   <para>rdfs:label : Pets^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that pets might be present.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Pets">tb:Pets</a>
    /// </summary>
    let Pets = _prefixId.prefix "Pets"
    /// <summary>
    ///   <para>rdfs:label : Phone Calls^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to perform phone calls.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PhoneCalls">tb:PhoneCalls</a>
    /// </summary>
    let PhoneCalls = _prefixId.prefix "PhoneCalls"
    /// <summary>
    ///   <para>rdfs:label : Physical Inconvenience^^xsd:string</para>
    ///   <para>rdfs:comment : This is a collection of physical disorders that negatively affect a person's daily life.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PhysicalInconvenience">tb:PhysicalInconvenience</a>
    /// </summary>
    let PhysicalInconvenience = _prefixId.prefix "PhysicalInconvenience"
    /// <summary>
    ///   <para>rdfs:label : Care for Physically Disabled^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care for the physically disabled.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PhysicallyDisabledCare">tb:PhysicallyDisabledCare</a>
    /// </summary>
    let PhysicallyDisabledCare = _prefixId.prefix "PhysicallyDisabledCare"
    /// <summary>
    ///   <para>rdfs:label : Plumbing^^xsd:string</para>
    ///   <para>rdfs:comment : Skill to perform plumbing and repairs on pipe installation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Plumbing">tb:Plumbing</a>
    /// </summary>
    let Plumbing = _prefixId.prefix "Plumbing"
    /// <summary>
    ///   <para>rdfs:label : Poor Eyesight^^xsd:string</para>
    ///   <para>rdfs:comment : Having difficulties seeing objects clearly.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PoorEyesight">tb:PoorEyesight</a>
    /// </summary>
    let PoorEyesight = _prefixId.prefix "PoorEyesight"
    /// <summary>
    ///   <para>rdfs:comment : Having difficulties hearing voices clearly.^^xsd:string</para>
    ///   <para>rdfs:label : Poor Hearing^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PoorHearing">tb:PoorHearing</a>
    /// </summary>
    let PoorHearing = _prefixId.prefix "PoorHearing"
    /// <summary>
    ///   <para>rdfs:label : Pruning^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with pruning shrubs and twigs.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Pruning">tb:Pruning</a>
    /// </summary>
    let Pruning = _prefixId.prefix "Pruning"
    /// <summary>
    ///   <para>rdfs:label : Psychotic Episode^^xsd:string</para>
    ///   <para>rdfs:comment : A person with psychotic episode can not tell the difference between the reality and unreality and may have difficulty with social activities in daily life.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#PsychoticEpisode">tb:PsychoticEpisode</a>
    /// </summary>
    let PsychoticEpisode = _prefixId.prefix "PsychoticEpisode"
    /// <summary>
    ///   <para>rdfs:label : Recording Notes^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with recording notes and entries.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#RecordingNotes">tb:RecordingNotes</a>
    /// </summary>
    let RecordingNotes = _prefixId.prefix "RecordingNotes"
    /// <summary>
    ///   <para>rdfs:label : Recreation^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide services related to recreation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Recreation">tb:Recreation</a>
    /// </summary>
    let Recreation = _prefixId.prefix "Recreation"
    /// <summary>
    ///   <para>rdfs:label : Repair^^xsd:string</para>
    ///   <para>rdfs:comment : The Skill to repair equipment and facilities.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Repair">tb:Repair</a>
    /// </summary>
    let Repair = _prefixId.prefix "Repair"
    /// <summary>
    ///   <para>rdfs:comment : A request for help from a Timebank user.^^xsd:string</para>
    ///   <para>rdfs:label : Request^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Request">tb:Request</a>
    /// </summary>
    let Request = _prefixId.prefix "Request"
    /// <summary>
    ///   <para>rdfs:label : Rheumatism^^xsd:string</para>
    ///   <para>rdfs:comment : Diseases that causes chronic pain in joints and muscles such as back, shoulder and neck.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Rheumatism">tb:Rheumatism</a>
    /// </summary>
    let Rheumatism = _prefixId.prefix "Rheumatism"
    /// <summary>
    ///   <para>rdfs:label : Sales Service^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to help with selling and buying products.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SalesService">tb:SalesService</a>
    /// </summary>
    let SalesService = _prefixId.prefix "SalesService"
    /// <summary>
    ///   <para>rdfs:label : Seafood Allergy^^xsd:string</para>
    ///   <para>rdfs:comment : Allergy to any kind of seafood.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SeafoodAllergy">tb:SeafoodAllergy</a>
    /// </summary>
    let SeafoodAllergy = _prefixId.prefix "SeafoodAllergy"
    /// <summary>
    ///   <para>rdfs:label : Sensitive Skin^^xsd:string</para>
    ///   <para>rdfs:comment : Skins are too sensitive to a wide variety of factors such as weather, pets, stress and dust.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SensitiveSkin">tb:SensitiveSkin</a>
    /// </summary>
    let SensitiveSkin = _prefixId.prefix "SensitiveSkin"
    /// <summary>
    ///   <para>rdfs:label : Sewing^^xsd:string</para>
    ///   <para>rdfs:comment : Specialized in sewing clothes.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Sewing">tb:Sewing</a>
    /// </summary>
    let Sewing = _prefixId.prefix "Sewing"
    /// <summary>
    ///   <para>rdfs:label : Care for Sick People^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide care for sick people.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SickCare">tb:SickCare</a>
    /// </summary>
    let SickCare = _prefixId.prefix "SickCare"
    /// <summary>
    ///   <para>rdfs:label : Skill^^xsd:string</para>
    ///   <para>rdfs:comment : Skills define the capabilities of a user. Users and Timebank requests can be associated to a certain skill (or multiple skills) to facilitate the matching of helper and requester.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Skill">tb:Skill</a>
    /// </summary>
    let Skill = _prefixId.prefix "Skill"
    /// <summary>
    ///   <para>rdfs:label : Splippery Floor^^xsd:string</para>
    ///   <para>rdfs:comment : The person needs to be aware of slippery floor.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SlipperyFloor">tb:SlipperyFloor</a>
    /// </summary>
    let SlipperyFloor = _prefixId.prefix "SlipperyFloor"
    /// <summary>
    ///   <para>rdfs:label : Speaking Problem^^xsd:string</para>
    ///   <para>rdfs:comment : The person has difficulties speaking clearly due to body function problems such as injuries to the brain, mouth or throat.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SpeakingProblem">tb:SpeakingProblem</a>
    /// </summary>
    let SpeakingProblem = _prefixId.prefix "SpeakingProblem"
    /// <summary>
    ///   <para>rdfs:comment : Fear of specific objects such as dogs, cats, heights, dark places, and so on.^^xsd:string</para>
    ///   <para>rdfs:label : Specific Phobia^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#SpecificPhobia">tb:SpecificPhobia</a>
    /// </summary>
    let SpecificPhobia = _prefixId.prefix "SpecificPhobia"
    /// <summary>
    ///   <para>rdfs:label : Sports^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to participate in sport activities.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Sports">tb:Sports</a>
    /// </summary>
    let Sports = _prefixId.prefix "Sports"
    /// <summary>
    ///   <para>rdfs:label : Stairs^^xsd:string</para>
    ///   <para>rdfs:comment : The person might have to climb stairs to complete the task.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Stairs">tb:Stairs</a>
    /// </summary>
    let Stairs = _prefixId.prefix "Stairs"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <para>rdfs:comment : The status of a request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Status">tb:Status</a>
    /// </summary>
    let Status = _prefixId.prefix "Status"
    let StatusAssigned = _prefixId.prefix "StatusAssigned"
    let StatusCancelled = _prefixId.prefix "StatusCancelled"
    let StatusClosed = _prefixId.prefix "StatusClosed"
    let StatusOpen = _prefixId.prefix "StatusOpen"
    /// <summary>
    ///   <para>rdfs:comment : It indicates a person once had a storke. A stroke happens when blood flow to the brain is blocked and oxygen for the brain cells is insufficient, which could leads to cell death.^^xsd:string</para>
    ///   <para>rdfs:label : History of Strokes^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#StrokeHistory">tb:StrokeHistory</a>
    /// </summary>
    let StrokeHistory = _prefixId.prefix "StrokeHistory"
    /// <summary>
    ///   <para>rdfs:label : Supplies^^xsd:string</para>
    ///   <para>rdfs:comment : Availability of specific supplies to complete a task.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Supplies">tb:Supplies</a>
    /// </summary>
    let Supplies = _prefixId.prefix "Supplies"
    /// <summary>
    ///   <para>rdfs:label : Tailoring^^xsd:string</para>
    ///   <para>rdfs:comment : Specialized in providing tailoring services.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Tailoring">tb:Tailoring</a>
    /// </summary>
    let Tailoring = _prefixId.prefix "Tailoring"
    /// <summary>
    ///   <para>rdfs:label : Toilet Using Problem^^xsd:string</para>
    ///   <para>rdfs:comment : The person has difficulties using toilet.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#ToiletUsingProblem">tb:ToiletUsingProblem</a>
    /// </summary>
    let ToiletUsingProblem = _prefixId.prefix "ToiletUsingProblem"
    /// <summary>
    ///   <para>rdfs:label : Tools^^xsd:string</para>
    ///   <para>rdfs:comment : Tools can be provided.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Tools">tb:Tools</a>
    /// </summary>
    let Tools = _prefixId.prefix "Tools"
    /// <summary>
    ///   <para>rdfs:label : TransportationServices^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to provide services related to transportation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Transportation">tb:Transportation</a>
    /// </summary>
    let Transportation = _prefixId.prefix "Transportation"
    /// <summary>
    ///   <para>rdfs:label : Transportation Available^^xsd:string</para>
    ///   <para>rdfs:comment : Transportation necessary to complete the task can be provided.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#TransportationAvailable">tb:TransportationAvailable</a>
    /// </summary>
    let TransportationAvailable = _prefixId.prefix "TransportationAvailable"
    /// <summary>
    ///   <para>rdfs:label : Travel Companion^^xsd:string</para>
    ///   <para>rdfs:comment : The ability to act as a travel companion.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#TravelCompanion">tb:TravelCompanion</a>
    /// </summary>
    let TravelCompanion = _prefixId.prefix "TravelCompanion"
    /// <summary>
    ///   <para>rdfs:label : Uneven Terrain^^xsd:string</para>
    ///   <para>rdfs:comment : The person needs equipment (e.g. shoes) suitable for uneven terrain.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#UnevenTerrain">tb:UnevenTerrain</a>
    /// </summary>
    let UnevenTerrain = _prefixId.prefix "UnevenTerrain"
    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <para>rdfs:comment : A user of the Timebank.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#User">tb:User</a>
    /// </summary>
    let User = _prefixId.prefix "User"
    /// <summary>
    ///   <para>rdfs:comment : The person has difficulties walking.^^xsd:string</para>
    ///   <para>rdfs:label : Walking Problem^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#WalkingProblem">tb:WalkingProblem</a>
    /// </summary>
    let WalkingProblem = _prefixId.prefix "WalkingProblem"
    /// <summary>
    ///   <para>rdfs:label : Water^^xsd:string</para>
    ///   <para>rdfs:comment : Water outlet is available.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Water">tb:Water</a>
    /// </summary>
    let Water = _prefixId.prefix "Water"
    /// <summary>
    ///   <para>rdfs:label : Weather Constraint^^xsd:string</para>
    ///   <para>rdfs:comment : The place is difficult to access during bad weather (e.g. snow).^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#WeatherConstraint">tb:WeatherConstraint</a>
    /// </summary>
    let WeatherConstraint = _prefixId.prefix "WeatherConstraint"
    /// <summary>
    ///   <para>rdfs:label : Wood Carving^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to Carve items out of wood.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#WoodCarving">tb:WoodCarving</a>
    /// </summary>
    let WoodCarving = _prefixId.prefix "WoodCarving"
    /// <summary>
    ///   <para>rdfs:label : Wood Crafting^^xsd:string</para>
    ///   <para>rdfs:comment : Crafting skill with wood as base material.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#WoodCrafting">tb:WoodCrafting</a>
    /// </summary>
    let WoodCrafting = _prefixId.prefix "WoodCrafting"
    /// <summary>
    ///   <para>rdfs:label : Writing^^xsd:string</para>
    ///   <para>rdfs:comment : The skill to assist with written work, like writing or reading a letter.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#Writing">tb:Writing</a>
    /// </summary>
    let Writing = _prefixId.prefix "Writing"
    /// <summary>
    ///   <para>rdfs:label : accepts^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a user who is willing to help accepted the request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#accepts">tb:accepts</a>
    /// </summary>
    let accepts = _prefixId.prefix "accepts"
    /// <summary>
    ///   <para>rdfs:label : ends repeating on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a time-interval is repeating until this time and date.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#endsRepeatingOn">tb:endsRepeatingOn</a>
    /// </summary>
    let endsRepeatingOn = _prefixId.prefix "endsRepeatingOn"
    /// <summary>
    ///   <para>rdfs:label : excludes user by limitation^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to describe that a request exludes helpers having a certain limitation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#excludesUserByLimitation">tb:excludesUserByLimitation</a>
    /// </summary>
    let excludesUserByLimitation = _prefixId.prefix "excludesUserByLimitation"
    /// <summary>
    ///   <para>rdfs:label : excludes user from^^xsd:string</para>
    ///   <para>rdfs:comment : This property is used to describe that a certain limitation excludes certain helpers from the request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#excludesUserFrom">tb:excludesUserFrom</a>
    /// </summary>
    let excludesUserFrom = _prefixId.prefix "excludesUserFrom"
    /// <summary>
    ///   <para>rdfs:label : has accredited duration^^xsd:string</para>
    ///   <para>rdfs:comment : The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasAccreditedDuration">tb:hasAccreditedDuration</a>
    /// </summary>
    let hasAccreditedDuration = _prefixId.prefix "hasAccreditedDuration"
    /// <summary>
    ///   <para>rdfs:label : has address part^^xsd:string</para>
    ///   <para>rdfs:comment : An address part that describes the location of a specific request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasAddressPart">tb:hasAddressPart</a>
    /// </summary>
    let hasAddressPart = _prefixId.prefix "hasAddressPart"
    /// <summary>
    ///   <para>rdfs:label : has environment^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain Location Specifier has a specific environmental factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasEnvironment">tb:hasEnvironment</a>
    /// </summary>
    let hasEnvironment = _prefixId.prefix "hasEnvironment"
    /// <summary>
    ///   <para>rdfs:label : has expected duration^^xsd:string</para>
    ///   <para>rdfs:comment : The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasExpectedDuration">tb:hasExpectedDuration</a>
    /// </summary>
    let hasExpectedDuration = _prefixId.prefix "hasExpectedDuration"
    /// <summary>
    ///   <para>rdfs:label : has limitation^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a Timebank user suffers from a certain limitation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasLimitation">tb:hasLimitation</a>
    /// </summary>
    let hasLimitation = _prefixId.prefix "hasLimitation"
    /// <summary>
    ///   <para>rdfs:label : has not environment^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain Location Specifier has a specific environmental factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasNotEnvironment">tb:hasNotEnvironment</a>
    /// </summary>
    let hasNotEnvironment = _prefixId.prefix "hasNotEnvironment"
    /// <summary>
    ///   <para>rdfs:label : has originator^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the request has the specific originator.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasOriginator">tb:hasOriginator</a>
    /// </summary>
    let hasOriginator = _prefixId.prefix "hasOriginator"
    /// <summary>
    ///   <para>rdfs:label : has severity^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the severity of a limitation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasSeverity">tb:hasSeverity</a>
    /// </summary>
    let hasSeverity = _prefixId.prefix "hasSeverity"
    /// <summary>
    ///   <para>rdfs:label : has skill^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the Skill of a certain Timebank user.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasSkill">tb:hasSkill</a>
    /// </summary>
    let hasSkill = _prefixId.prefix "hasSkill"
    /// <summary>
    ///   <para>rdfs:label : has skill level^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the proficiency level of a skill.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasSkillLevel">tb:hasSkillLevel</a>
    /// </summary>
    let hasSkillLevel = _prefixId.prefix "hasSkillLevel"
    /// <summary>
    ///   <para>rdfs:label : has status^^xsd:string</para>
    ///   <para>rdfs:comment : Every request can have at most one status assigned to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasStatus">tb:hasStatus</a>
    /// </summary>
    let hasStatus = _prefixId.prefix "hasStatus"
    /// <summary>
    ///   <para>rdfs:label : has sub-part^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasSubPart">tb:hasSubPart</a>
    /// </summary>
    let hasSubPart = _prefixId.prefix "hasSubPart"
    /// <summary>
    ///   <para>rdfs:label : has time-balance^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the current time-balance of a Timebank user.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasTimeBalance">tb:hasTimeBalance</a>
    /// </summary>
    let hasTimeBalance = _prefixId.prefix "hasTimeBalance"
    /// <summary>
    ///   <para>rdfs:label : has time window^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time window in which the request can/should be completed.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#hasTimeWindow">tb:hasTimeWindow</a>
    /// </summary>
    let hasTimeWindow = _prefixId.prefix "hasTimeWindow"
    /// <summary>
    ///   <para>rdfs:label : is acceptance date of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date when the Timebank request was accepted by the assigned helper.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAcceptanceDateOf">tb:isAcceptanceDateOf</a>
    /// </summary>
    let isAcceptanceDateOf = _prefixId.prefix "isAcceptanceDateOf"
    /// <summary>
    ///   <para>rdfs:label : is accepted by^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a request is accepted by a user who is willing to help completing the request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAcceptedBy">tb:isAcceptedBy</a>
    /// </summary>
    let isAcceptedBy = _prefixId.prefix "isAcceptedBy"
    /// <summary>
    ///   <para>rdfs:label : is accepted on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date when the Timebank request was accepted by the assigned helper.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAcceptedOn">tb:isAcceptedOn</a>
    /// </summary>
    let isAcceptedOn = _prefixId.prefix "isAcceptedOn"
    /// <summary>
    ///   <para>rdfs:label : is accredited to^^xsd:string</para>
    ///   <para>rdfs:comment : The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAccreditedTo">tb:isAccreditedTo</a>
    /// </summary>
    let isAccreditedTo = _prefixId.prefix "isAccreditedTo"
    /// <summary>
    ///   <para>rdfs:label : is adress part of^^xsd:string</para>
    ///   <para>rdfs:comment : An address part that describes the location of a specific request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAdressPartOf">tb:isAdressPartOf</a>
    /// </summary>
    let isAdressPartOf = _prefixId.prefix "isAdressPartOf"
    /// <summary>
    ///   <para>rdfs:label : is availability of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the availability of a Timebank user to act as a helper for a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAvailabilityOf">tb:isAvailabilityOf</a>
    /// </summary>
    let isAvailabilityOf = _prefixId.prefix "isAvailabilityOf"
    /// <summary>
    ///   <para>rdfs:label : is available on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the availability of a Timebank user to act as a helper for a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isAvailableOn">tb:isAvailableOn</a>
    /// </summary>
    let isAvailableOn = _prefixId.prefix "isAvailableOn"
    /// <summary>
    ///   <para>rdfs:label : is cancellation date of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date when the Timebank request was cancelled.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isCancellationDateOf">tb:isCancellationDateOf</a>
    /// </summary>
    let isCancellationDateOf = _prefixId.prefix "isCancellationDateOf"
    /// <summary>
    ///   <para>rdfs:label : is cancelled on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date when the Timebank request was cancelled.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isCancelledOn">tb:isCancelledOn</a>
    /// </summary>
    let isCancelledOn = _prefixId.prefix "isCancelledOn"
    /// <summary>
    ///   <para>rdfs:label : is completed on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date of the completion of a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isCompletedOn">tb:isCompletedOn</a>
    /// </summary>
    let isCompletedOn = _prefixId.prefix "isCompletedOn"
    /// <summary>
    ///   <para>rdfs:label : is completion date of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date of the completion of a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isCompletionDateOf">tb:isCompletionDateOf</a>
    /// </summary>
    let isCompletionDateOf = _prefixId.prefix "isCompletionDateOf"
    /// <summary>
    ///   <para>rdfs:label : is environment of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain Location Specifier has a specific environmental factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isEnvironmentOf">tb:isEnvironmentOf</a>
    /// </summary>
    let isEnvironmentOf = _prefixId.prefix "isEnvironmentOf"
    /// <summary>
    ///   <para>rdfs:label : is expected duration of^^xsd:string</para>
    ///   <para>rdfs:comment : The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isExpectedDurationOf">tb:isExpectedDurationOf</a>
    /// </summary>
    let isExpectedDurationOf = _prefixId.prefix "isExpectedDurationOf"
    /// <summary>
    ///   <para>rdfs:label : is limitation of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain limitation applies to the Timebank user.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isLimitationOf">tb:isLimitationOf</a>
    /// </summary>
    let isLimitationOf = _prefixId.prefix "isLimitationOf"
    /// <summary>
    ///   <para>rdfs:label : is not environment of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a certain Location Specifier has a specific environmental factor.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isNotEnvironmentOf">tb:isNotEnvironmentOf</a>
    /// </summary>
    let isNotEnvironmentOf = _prefixId.prefix "isNotEnvironmentOf"
    /// <summary>
    ///   <para>rdfs:label : is originator of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the user is the originator of the request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isOriginatorOf">tb:isOriginatorOf</a>
    /// </summary>
    let isOriginatorOf = _prefixId.prefix "isOriginatorOf"
    /// <summary>
    ///   <para>rdfs:label : is publication date of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date of the publication of a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isPublicationDateOf">tb:isPublicationDateOf</a>
    /// </summary>
    let isPublicationDateOf = _prefixId.prefix "isPublicationDateOf"
    /// <summary>
    ///   <para>rdfs:label : is published on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time and date of the publication of a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isPublishedOn">tb:isPublishedOn</a>
    /// </summary>
    let isPublishedOn = _prefixId.prefix "isPublishedOn"
    /// <summary>
    ///   <para>rdfs:label : is repeating endpoint of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a specific time and date marks the end of a repetition of a time-interval.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isRepeatingEndpointOf">tb:isRepeatingEndpointOf</a>
    /// </summary>
    let isRepeatingEndpointOf = _prefixId.prefix "isRepeatingEndpointOf"
    /// <summary>
    ///   <para>rdfs:label : is repetition date of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a time interval repeats on the specified weekdays.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isRepetitionDayOf">tb:isRepetitionDayOf</a>
    /// </summary>
    let isRepetitionDayOf = _prefixId.prefix "isRepetitionDayOf"
    /// <summary>
    ///   <para>rdfs:label : is required by^^xsd:string</para>
    ///   <para>rdfs:comment : The skill associated with a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isRequiredBy">tb:isRequiredBy</a>
    /// </summary>
    let isRequiredBy = _prefixId.prefix "isRequiredBy"
    /// <summary>
    ///   <para>rdfs:label : is severity of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the severity of a limitation.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isSeverityOf">tb:isSeverityOf</a>
    /// </summary>
    let isSeverityOf = _prefixId.prefix "isSeverityOf"
    /// <summary>
    ///   <para>rdfs:label : is skill level of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the proficiency level of a skill.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isSkillLevelOf">tb:isSkillLevelOf</a>
    /// </summary>
    let isSkillLevelOf = _prefixId.prefix "isSkillLevelOf"
    /// <summary>
    ///   <para>rdfs:label : is skill of^^xsd:string</para>
    ///   <para>rdfs:comment : Describes the Skill of a certain Timebank user.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isSkillOf">tb:isSkillOf</a>
    /// </summary>
    let isSkillOf = _prefixId.prefix "isSkillOf"
    /// <summary>
    ///   <para>rdfs:label : is status of^^xsd:string</para>
    ///   <para>rdfs:comment : Every request can have at most one status assigned to it.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isStatusOf">tb:isStatusOf</a>
    /// </summary>
    let isStatusOf = _prefixId.prefix "isStatusOf"
    /// <summary>
    ///   <para>rdfs:label : is sub-part of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isSubPartOf">tb:isSubPartOf</a>
    /// </summary>
    let isSubPartOf = _prefixId.prefix "isSubPartOf"
    /// <summary>
    ///   <para>rdfs:label : is time-balance of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the current time-balance of a Timebank user.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isTimeBalanceOf">tb:isTimeBalanceOf</a>
    /// </summary>
    let isTimeBalanceOf = _prefixId.prefix "isTimeBalanceOf"
    /// <summary>
    ///   <para>rdfs:label : is time window of^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the time window in which the request can/should be completed.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#isTimeWindowOf">tb:isTimeWindowOf</a>
    /// </summary>
    let isTimeWindowOf = _prefixId.prefix "isTimeWindowOf"
    /// <summary>
    ///   <para>rdfs:label : rating^^xsd:string</para>
    ///   <para>rdfs:comment : The rating given by the originator of a request to the assigned helper for completing the specific request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#rating">tb:rating</a>
    /// </summary>
    let rating = _prefixId.prefix "rating"
    /// <summary>
    ///   <para>rdfs:label : repeats on^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that a time interval repeats on the specified weekdays.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#repeatsOn">tb:repeatsOn</a>
    /// </summary>
    let repeatsOn = _prefixId.prefix "repeatsOn"
    /// <summary>
    ///   <para>rdfs:label : requires skill^^xsd:string</para>
    ///   <para>rdfs:comment : The skill associated with a Timebank request.^^xsd:string</para>
    ///   <a href="https://w3id.org/timebank#requiresSkill">tb:requiresSkill</a>
    /// </summary>
    let requiresSkill = _prefixId.prefix "requiresSkill"
