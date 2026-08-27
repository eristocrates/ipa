namespace https.w3id.org.timebank.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tb =
    let _namespace_iri = Namespace_Iri tb |> NamespaceIRI
    /// <summary>
    ///   <para>w3id:timebank#Accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describes any revelant information regarding the accessibility of a location of a request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accessibility"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Accessibility">https://w3id.org/timebank#Accessibility</seealso>
    let Accessibility = Prefixed_Name(tb, "Accessibility") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#AccessibleByPublicTransport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The location is accessible by public transport."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Accessible by Public Transport"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AccessibleByPublicTransport">https://w3id.org/timebank#AccessibleByPublicTransport</seealso>
    let AccessibleByPublicTransport =
        Prefixed_Name(tb, "AccessibleByPublicTransport") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#AddressPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An address part indicates part of an address like region, city, etc. If two places share the same address part, they also share the same environmental factors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Address Part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AddressPart">https://w3id.org/timebank#AddressPart</seealso>
    let AddressPart = Prefixed_Name(tb, "AddressPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Advice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Skills to provide particular services which requires some sort of education or training."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Advice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Advice">https://w3id.org/timebank#Advice</seealso>
    let Advice = Prefixed_Name(tb, "Advice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Allergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A collection of allergies, which is caused by hypersensitivity of the immune system."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Allergy">https://w3id.org/timebank#Allergy</seealso>
    let Allergy = Prefixed_Name(tb, "Allergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Assembling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assemble items like furniture and other things."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Assembling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Assembling">https://w3id.org/timebank#Assembling</seealso>
    let Assembling = Prefixed_Name(tb, "Assembling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#AutomobileRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to repair automobiles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Automobile Repair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#AutomobileRepair">https://w3id.org/timebank#AutomobileRepair</seealso>
    let AutomobileRepair = Prefixed_Name(tb, "AutomobileRepair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Baking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with baking."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Baking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Baking">https://w3id.org/timebank#Baking</seealso>
    let Baking = Prefixed_Name(tb, "Baking") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Carpeting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to do carpenting."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Carpenting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Carpeting">https://w3id.org/timebank#Carpeting</seealso>
    let Carpeting = Prefixed_Name(tb, "Carpeting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Catering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with catering requirements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Catering"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Catering">https://w3id.org/timebank#Catering</seealso>
    let Catering = Prefixed_Name(tb, "Catering") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Cats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that cats might be present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cats">https://w3id.org/timebank#Cats</seealso>
    let Cats = Prefixed_Name(tb, "Cats") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ChildCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide care for children."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Child Care"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ChildCare">https://w3id.org/timebank#ChildCare</seealso>
    let ChildCare = Prefixed_Name(tb, "ChildCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Cleaning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with general cleaning tasks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cleaning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cleaning">https://w3id.org/timebank#Cleaning</seealso>
    let Cleaning = Prefixed_Name(tb, "Cleaning") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#ClimbingStairsDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The person has difficulty in climbing up stairs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Difficulty in Climbing Stairs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ClimbingStairsDifficulty">https://w3id.org/timebank#ClimbingStairsDifficulty</seealso>
    let ClimbingStairsDifficulty =
        Prefixed_Name(tb, "ClimbingStairsDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#ClothesWashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with washing clothes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Clothes Washing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ClothesWashing">https://w3id.org/timebank#ClothesWashing</seealso>
    let ClothesWashing = Prefixed_Name(tb, "ClothesWashing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#CognitiveImpairment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person with cognitive impairment can't think and remember things clearly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cognitive Impairment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CognitiveImpairment">https://w3id.org/timebank#CognitiveImpairment</seealso>
    let CognitiveImpairment = Prefixed_Name(tb, "CognitiveImpairment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#CommonDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A collection of diseases that are common, especially for elderly people"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Common Disease"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CommonDisease">https://w3id.org/timebank#CommonDisease</seealso>
    let CommonDisease = Prefixed_Name(tb, "CommonDisease") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ComputerProcessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with processing data computers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Processing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ComputerProcessing">https://w3id.org/timebank#ComputerProcessing</seealso>
    let ComputerProcessing = Prefixed_Name(tb, "ComputerProcessing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ComputerRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to fix problems with computers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Computer Repair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ComputerRepair">https://w3id.org/timebank#ComputerRepair</seealso>
    let ComputerRepair = Prefixed_Name(tb, "ComputerRepair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Cooking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with cooking in general."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cooking"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Cooking">https://w3id.org/timebank#Cooking</seealso>
    let Cooking = Prefixed_Name(tb, "Cooking") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Counseling</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to advice people on psychological matters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Counseling"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Counseling">https://w3id.org/timebank#Counseling</seealso>
    let Counseling = Prefixed_Name(tb, "Counseling") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Crafting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Crafting skills."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Crafting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Crafting">https://w3id.org/timebank#Crafting</seealso>
    let Crafting = Prefixed_Name(tb, "Crafting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#CraftingClothes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The ability to craft any kind of clothes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Crafting Clothes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#CraftingClothes">https://w3id.org/timebank#CraftingClothes</seealso>
    let CraftingClothes = Prefixed_Name(tb, "CraftingClothes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DancingCompanion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The ability to act as a dancing companion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dancing Companion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DancingCompanion">https://w3id.org/timebank#DancingCompanion</seealso>
    let DancingCompanion = Prefixed_Name(tb, "DancingCompanion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Depression</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A person with depression has a depressed mood over a long period and may even have thoughts of suicide."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Depression"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Depression">https://w3id.org/timebank#Depression</seealso>
    let Depression = Prefixed_Name(tb, "Depression") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Diabetes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"A disorder characterized by high blood sugar levels during a long period."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Diabetes Mellitus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Diabetes">https://w3id.org/timebank#Diabetes</seealso>
    let Diabetes = Prefixed_Name(tb, "Diabetes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Dishwashing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with washing dishes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dishwashing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Dishwashing">https://w3id.org/timebank#Dishwashing</seealso>
    let Dishwashing = Prefixed_Name(tb, "Dishwashing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Dogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates that dogs might be present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dogs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Dogs">https://w3id.org/timebank#Dogs</seealso>
    let Dogs = Prefixed_Name(tb, "Dogs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DressingAssistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist someone with dressing."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dressing Assistance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DressingAssistance">https://w3id.org/timebank#DressingAssistance</seealso>
    let DressingAssistance = Prefixed_Name(tb, "DressingAssistance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DressingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The person has difficulties dressing himself."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Dressing Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DressingProblem">https://w3id.org/timebank#DressingProblem</seealso>
    let DressingProblem = Prefixed_Name(tb, "DressingProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingCars</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Experience in driving cars."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Cars"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingCars">https://w3id.org/timebank#DrivingCars</seealso>
    let DrivingCars = Prefixed_Name(tb, "DrivingCars") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingHeavyVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Experience in driving heavy vehicles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Heavy Vehicles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingHeavyVehicles">https://w3id.org/timebank#DrivingHeavyVehicles</seealso>
    let DrivingHeavyVehicles = Prefixed_Name(tb, "DrivingHeavyVehicles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingLightVehicles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Experience in driving light vehicles."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Light Vehicles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingLightVehicles">https://w3id.org/timebank#DrivingLightVehicles</seealso>
    let DrivingLightVehicles = Prefixed_Name(tb, "DrivingLightVehicles") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingTractors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Experience in driving tractors."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Tractors"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingTractors">https://w3id.org/timebank#DrivingTractors</seealso>
    let DrivingTractors = Prefixed_Name(tb, "DrivingTractors") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingTrucks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Experience in driving with trucks."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Trucks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingTrucks">https://w3id.org/timebank#DrivingTrucks</seealso>
    let DrivingTrucks = Prefixed_Name(tb, "DrivingTrucks") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingVans</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Experience in driving vans."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving Vans"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingVans">https://w3id.org/timebank#DrivingVans</seealso>
    let DrivingVans = Prefixed_Name(tb, "DrivingVans") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrivingWithTrailers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Experience in driving with trailers."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Driving with Trailers"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrivingWithTrailers">https://w3id.org/timebank#DrivingWithTrailers</seealso>
    let DrivingWithTrailers = Prefixed_Name(tb, "DrivingWithTrailers") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#DrugAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"An allergy to drugs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Drug Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#DrugAllergy">https://w3id.org/timebank#DrugAllergy</seealso>
    let DrugAllergy = Prefixed_Name(tb, "DrugAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#EggAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Allergy to eggs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Egg Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EggAllergy">https://w3id.org/timebank#EggAllergy</seealso>
    let EggAllergy = Prefixed_Name(tb, "EggAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ElderlyCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide care and support for the elderly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Care for Elderly"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ElderlyCare">https://w3id.org/timebank#ElderlyCare</seealso>
    let ElderlyCare = Prefixed_Name(tb, "ElderlyCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Electricity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Electric outlet available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electricity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Electricity">https://w3id.org/timebank#Electricity</seealso>
    let Electricity = Prefixed_Name(tb, "Electricity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ElectronicRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to repair electronic devices."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Electronic Repair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ElectronicRepair">https://w3id.org/timebank#ElectronicRepair</seealso>
    let ElectronicRepair = Prefixed_Name(tb, "ElectronicRepair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Environment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The environment describes relevant environmental factors of a request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Environment">https://w3id.org/timebank#Environment</seealso>
    let Environment = Prefixed_Name(tb, "Environment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#EnvironmentalAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An allergy to something in the environment such as dust mites, pollen, pet hair and cigarette smoke."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Environmental Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EnvironmentalAllergy">https://w3id.org/timebank#EnvironmentalAllergy</seealso>
    let EnvironmentalAllergy = Prefixed_Name(tb, "EnvironmentalAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#EventPlanning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist in planning and hosting events."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Event Planning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#EventPlanning">https://w3id.org/timebank#EventPlanning</seealso>
    let EventPlanning = Prefixed_Name(tb, "EventPlanning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FearOfAnimals</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Fear of animals. This can include dogs, cats, snakes, insects, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fear of Animals"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfAnimals">https://w3id.org/timebank#FearOfAnimals</seealso>
    let FearOfAnimals = Prefixed_Name(tb, "FearOfAnimals") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FearOfCats</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Fear of cats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fear of Cats"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfCats">https://w3id.org/timebank#FearOfCats</seealso>
    let FearOfCats = Prefixed_Name(tb, "FearOfCats") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FearOfDark</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Fear of dark places."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fear of Dark"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfDark">https://w3id.org/timebank#FearOfDark</seealso>
    let FearOfDark = Prefixed_Name(tb, "FearOfDark") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FearOfDogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Fear of dogs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fear of Dogs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfDogs">https://w3id.org/timebank#FearOfDogs</seealso>
    let FearOfDogs = Prefixed_Name(tb, "FearOfDogs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FearOfHeights</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Fear or phobia of heights."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Fear of Heights"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FearOfHeights">https://w3id.org/timebank#FearOfHeights</seealso>
    let FearOfHeights = Prefixed_Name(tb, "FearOfHeights") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FinancialAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specialized in providing assistance with financial services. This can include helping with taxes and book keeping."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Financial Advice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FinancialAdvice">https://w3id.org/timebank#FinancialAdvice</seealso>
    let FinancialAdvice = Prefixed_Name(tb, "FinancialAdvice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FoodAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"An allergy to food such as milk, peanuts, eggs, fish, tree nuts, and fruit."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodAllergy">https://w3id.org/timebank#FoodAllergy</seealso>
    let FoodAllergy = Prefixed_Name(tb, "FoodAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FoodPreparation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with food preparation like meat cutting, washing of food, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Preparation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodPreparation">https://w3id.org/timebank#FoodPreparation</seealso>
    let FoodPreparation = Prefixed_Name(tb, "FoodPreparation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#FoodService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide services related to food products."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Food Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#FoodService">https://w3id.org/timebank#FoodService</seealso>
    let FoodService = Prefixed_Name(tb, "FoodService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Games</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to participate in board games, card games, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Games"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Games">https://w3id.org/timebank#Games</seealso>
    let Games = Prefixed_Name(tb, "Games") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#GlutenAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Allergies to grains with gluten such as wheat, barley, rye, and oats."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Gluten Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#GlutenAllergy">https://w3id.org/timebank#GlutenAllergy</seealso>
    let GlutenAllergy = Prefixed_Name(tb, "GlutenAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Groceries</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to help buying groceries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Groceries"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Groceries">https://w3id.org/timebank#Groceries</seealso>
    let Groceries = Prefixed_Name(tb, "Groceries") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#HairCutting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Ability to cut someone else's hair."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hair Cutting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HairCutting">https://w3id.org/timebank#HairCutting</seealso>
    let HairCutting = Prefixed_Name(tb, "HairCutting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#HeartDisease</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A condition of diseases that negatively affect one's heart such as blood vessel diseases and heart rhythm problems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Heart Diseases"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HeartDisease">https://w3id.org/timebank#HeartDisease</seealso>
    let HeartDisease = Prefixed_Name(tb, "HeartDisease") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#HouseholdEquipmentRepair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to repair household equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Houseshold Equipment Repair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HouseholdEquipmentRepair">https://w3id.org/timebank#HouseholdEquipmentRepair</seealso>
    let HouseholdEquipmentRepair =
        Prefixed_Name(tb, "HouseholdEquipmentRepair") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#HygieneAssitance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist someone on hygienical matters."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hygiene Assitance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#HygieneAssitance">https://w3id.org/timebank#HygieneAssitance</seealso>
    let HygieneAssitance = Prefixed_Name(tb, "HygieneAssitance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Hypertension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The blood pressure is high in a long period."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypertension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Hypertension">https://w3id.org/timebank#Hypertension</seealso>
    let Hypertension = Prefixed_Name(tb, "Hypertension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Hypotension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The blood pressure is low in a long period."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hypotension"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Hypotension">https://w3id.org/timebank#Hypotension</seealso>
    let Hypotension = Prefixed_Name(tb, "Hypotension") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Internet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Internet is available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Internet"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Internet">https://w3id.org/timebank#Internet</seealso>
    let Internet = Prefixed_Name(tb, "Internet") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#InventoryManagement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with inventory management."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Inventory Management"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#InventoryManagement">https://w3id.org/timebank#InventoryManagement</seealso>
    let InventoryManagement = Prefixed_Name(tb, "InventoryManagement") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Knitting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Specialized in knitting clothes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Knitting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Knitting">https://w3id.org/timebank#Knitting</seealso>
    let Knitting = Prefixed_Name(tb, "Knitting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#LegalAdvice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Specialized in providing legal assistance."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Legal Advice"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LegalAdvice">https://w3id.org/timebank#LegalAdvice</seealso>
    let LegalAdvice = Prefixed_Name(tb, "LegalAdvice") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Level</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The level can be low, medium, or high."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Level">https://w3id.org/timebank#Level</seealso>
    let Level = Prefixed_Name(tb, "Level") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#LevelHigh</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>"Used if a Limitation has a high severity or a Skill is on a high level."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level: High"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelHigh">https://w3id.org/timebank#LevelHigh</seealso>
    let LevelHigh = Prefixed_Name(tb, "LevelHigh") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#LevelLow</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Used if a Limitation only has a low severity or a Skill is on a low level."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level: Low"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelLow">https://w3id.org/timebank#LevelLow</seealso>
    let LevelLow = Prefixed_Name(tb, "LevelLow") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#LevelMedium</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Level</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Used if a Limitation has a medium severity or a Skill is on a medium level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Level: Medium"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LevelMedium">https://w3id.org/timebank#LevelMedium</seealso>
    let LevelMedium = Prefixed_Name(tb, "LevelMedium") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Lift</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A lift/elevator is available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="https://w3id.org/timebank#Lift">https://w3id.org/timebank#Lift</seealso>
    let Lift = Prefixed_Name(tb, "Lift") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Limitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Limitations can be anything which prevents or limits the extent to which a user can help somebody else."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Limitation">https://w3id.org/timebank#Limitation</seealso>
    let Limitation = Prefixed_Name(tb, "Limitation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#LimitedAccessibilityRain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The place is difficult to access during rainfall."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limited Accessibility: Rain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LimitedAccessibilityRain">https://w3id.org/timebank#LimitedAccessibilityRain</seealso>
    let LimitedAccessibilityRain =
        Prefixed_Name(tb, "LimitedAccessibilityRain") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#LimitedAccessibilitySnow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The place is difficult to access during snowfall."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Limited Accessibility: Snow"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#LimitedAccessibilitySnow">https://w3id.org/timebank#LimitedAccessibilitySnow</seealso>
    let LimitedAccessibilitySnow =
        Prefixed_Name(tb, "LimitedAccessibilitySnow") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#Maintenance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to help with maintenance of equipment."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Maintenance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Maintenance">https://w3id.org/timebank#Maintenance</seealso>
    let Maintenance = Prefixed_Name(tb, "Maintenance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#MentalDisorder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Disorders that affect the mental states of a person."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mental Disorder"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MentalDisorder">https://w3id.org/timebank#MentalDisorder</seealso>
    let MentalDisorder = Prefixed_Name(tb, "MentalDisorder") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#MentallyIllCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to provide care for the mentally ill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Care Mentally Ill People"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MentallyIllCare">https://w3id.org/timebank#MentallyIllCare</seealso>
    let MentallyIllCare = Prefixed_Name(tb, "MentallyIllCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#MilkAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Allergy to milk."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Milk Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MilkAllergy">https://w3id.org/timebank#MilkAllergy</seealso>
    let MilkAllergy = Prefixed_Name(tb, "MilkAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#MobilityProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Difficulties with moving around physically such as having difficulties using toliet, dressing, walking and so on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mobility Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#MobilityProblem">https://w3id.org/timebank#MobilityProblem</seealso>
    let MobilityProblem = Prefixed_Name(tb, "MobilityProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Mopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with mopping floors, etc."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mopping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Mopping">https://w3id.org/timebank#Mopping</seealso>
    let Mopping = Prefixed_Name(tb, "Mopping") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Mowing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with mowing the grass."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mowing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Mowing">https://w3id.org/timebank#Mowing</seealso>
    let Mowing = Prefixed_Name(tb, "Mowing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#NutsAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Allergy to nuts such as almonds, walnuts, pecans, and peanuts."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Nuts Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#NutsAllergy">https://w3id.org/timebank#NutsAllergy</seealso>
    let NutsAllergy = Prefixed_Name(tb, "NutsAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#OfficeWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide help with office related work."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Office Work"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#OfficeWork">https://w3id.org/timebank#OfficeWork</seealso>
    let OfficeWork = Prefixed_Name(tb, "OfficeWork") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#OnlineShopping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist in buying things online."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Online Shopping"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#OnlineShopping">https://w3id.org/timebank#OnlineShopping</seealso>
    let OnlineShopping = Prefixed_Name(tb, "OnlineShopping") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PeopleCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide care for people."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Care for People"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PeopleCare">https://w3id.org/timebank#PeopleCare</seealso>
    let PeopleCare = Prefixed_Name(tb, "PeopleCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PerformingMusic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to entertain others by performing music."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Performing Music"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PerformingMusic">https://w3id.org/timebank#PerformingMusic</seealso>
    let PerformingMusic = Prefixed_Name(tb, "PerformingMusic") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PersonalService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Personal services which include hygiene and daily care."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Personal Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PersonalService">https://w3id.org/timebank#PersonalService</seealso>
    let PersonalService = Prefixed_Name(tb, "PersonalService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Pets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Indicates that pets might be present."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Pets">https://w3id.org/timebank#Pets</seealso>
    let Pets = Prefixed_Name(tb, "Pets") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PhoneCalls</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to perform phone calls."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phone Calls"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhoneCalls">https://w3id.org/timebank#PhoneCalls</seealso>
    let PhoneCalls = Prefixed_Name(tb, "PhoneCalls") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#PhysicalInconvenience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"This is a collection of physical disorders that negatively affect a person's daily life."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Physical Inconvenience"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhysicalInconvenience">https://w3id.org/timebank#PhysicalInconvenience</seealso>
    let PhysicalInconvenience =
        Prefixed_Name(tb, "PhysicalInconvenience") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#PhysicallyDisabledCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide care for the physically disabled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Care for Physically Disabled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PhysicallyDisabledCare">https://w3id.org/timebank#PhysicallyDisabledCare</seealso>
    let PhysicallyDisabledCare =
        Prefixed_Name(tb, "PhysicallyDisabledCare") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#Plumbing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Skill to perform plumbing and repairs on pipe installation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Plumbing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Plumbing">https://w3id.org/timebank#Plumbing</seealso>
    let Plumbing = Prefixed_Name(tb, "Plumbing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PoorEyesight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Having difficulties seeing objects clearly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Poor Eyesight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PoorEyesight">https://w3id.org/timebank#PoorEyesight</seealso>
    let PoorEyesight = Prefixed_Name(tb, "PoorEyesight") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PoorHearing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Having difficulties hearing voices clearly."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Poor Hearing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PoorHearing">https://w3id.org/timebank#PoorHearing</seealso>
    let PoorHearing = Prefixed_Name(tb, "PoorHearing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Pruning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with pruning shrubs and twigs."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pruning"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Pruning">https://w3id.org/timebank#Pruning</seealso>
    let Pruning = Prefixed_Name(tb, "Pruning") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#PsychoticEpisode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"A person with psychotic episode can not tell the difference between the reality and unreality and may have difficulty with social activities in daily life."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Psychotic Episode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#PsychoticEpisode">https://w3id.org/timebank#PsychoticEpisode</seealso>
    let PsychoticEpisode = Prefixed_Name(tb, "PsychoticEpisode") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#RecordingNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to assist with recording notes and entries."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recording Notes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#RecordingNotes">https://w3id.org/timebank#RecordingNotes</seealso>
    let RecordingNotes = Prefixed_Name(tb, "RecordingNotes") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Recreation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide services related to recreation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Recreation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Recreation">https://w3id.org/timebank#Recreation</seealso>
    let Recreation = Prefixed_Name(tb, "Recreation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Skill to repair equipment and facilities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Repair"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Repair">https://w3id.org/timebank#Repair</seealso>
    let Repair = Prefixed_Name(tb, "Repair") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Request</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A request for help from a Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Request"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Request">https://w3id.org/timebank#Request</seealso>
    let Request = Prefixed_Name(tb, "Request") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Rheumatism</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Diseases that causes chronic pain in joints and muscles such as back, shoulder and neck."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Rheumatism"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Rheumatism">https://w3id.org/timebank#Rheumatism</seealso>
    let Rheumatism = Prefixed_Name(tb, "Rheumatism") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SalesService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to help with selling and buying products."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sales Service"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SalesService">https://w3id.org/timebank#SalesService</seealso>
    let SalesService = Prefixed_Name(tb, "SalesService") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SeafoodAllergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Allergy to any kind of seafood."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Seafood Allergy"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SeafoodAllergy">https://w3id.org/timebank#SeafoodAllergy</seealso>
    let SeafoodAllergy = Prefixed_Name(tb, "SeafoodAllergy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SensitiveSkin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Skins are too sensitive to a wide variety of factors such as weather, pets, stress and dust."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sensitive Skin"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SensitiveSkin">https://w3id.org/timebank#SensitiveSkin</seealso>
    let SensitiveSkin = Prefixed_Name(tb, "SensitiveSkin") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Sewing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Specialized in sewing clothes."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sewing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Sewing">https://w3id.org/timebank#Sewing</seealso>
    let Sewing = Prefixed_Name(tb, "Sewing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SickCare</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide care for sick people."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Care for Sick People"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SickCare">https://w3id.org/timebank#SickCare</seealso>
    let SickCare = Prefixed_Name(tb, "SickCare") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Skill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Skills define the capabilities of a user. Users and Timebank requests can be associated to a certain skill (or multiple skills) to facilitate the matching of helper and requester."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Skill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Skill">https://w3id.org/timebank#Skill</seealso>
    let Skill = Prefixed_Name(tb, "Skill") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SlipperyFloor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The person needs to be aware of slippery floor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Splippery Floor"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SlipperyFloor">https://w3id.org/timebank#SlipperyFloor</seealso>
    let SlipperyFloor = Prefixed_Name(tb, "SlipperyFloor") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SpeakingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The person has difficulties speaking clearly due to body function problems such as injuries to the brain, mouth or throat."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Speaking Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SpeakingProblem">https://w3id.org/timebank#SpeakingProblem</seealso>
    let SpeakingProblem = Prefixed_Name(tb, "SpeakingProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#SpecificPhobia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Fear of specific objects such as dogs, cats, heights, dark places, and so on."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Specific Phobia"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#SpecificPhobia">https://w3id.org/timebank#SpecificPhobia</seealso>
    let SpecificPhobia = Prefixed_Name(tb, "SpecificPhobia") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Sports</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to participate in sport activities."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Sports"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Sports">https://w3id.org/timebank#Sports</seealso>
    let Sports = Prefixed_Name(tb, "Sports") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Stairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The person might have to climb stairs to complete the task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stairs"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Stairs">https://w3id.org/timebank#Stairs</seealso>
    let Stairs = Prefixed_Name(tb, "Stairs") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The status of a request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Status">https://w3id.org/timebank#Status</seealso>
    let Status = Prefixed_Name(tb, "Status") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#StatusAssigned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>"Indicates that a request is assigned to a helper but not yet completed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status: Assigned"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusAssigned">https://w3id.org/timebank#StatusAssigned</seealso>
    let StatusAssigned = Prefixed_Name(tb, "StatusAssigned") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#StatusCancelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>"Indicates that a request is cancelled and no helper is needed anymore."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status: Cancelled"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusCancelled">https://w3id.org/timebank#StatusCancelled</seealso>
    let StatusCancelled = Prefixed_Name(tb, "StatusCancelled") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#StatusClosed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>"Indicates that a request is closed and that no helper is needed anymore."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status: Closed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusClosed">https://w3id.org/timebank#StatusClosed</seealso>
    let StatusClosed = Prefixed_Name(tb, "StatusClosed") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#StatusOpen</para>
    /// </summary>
    /// <remarks>
    ///   <para>w3id:timebank#Status</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Indicates that a request is open and no helper is assigned to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status: Open"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StatusOpen">https://w3id.org/timebank#StatusOpen</seealso>
    let StatusOpen = Prefixed_Name(tb, "StatusOpen") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#StrokeHistory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"It indicates a person once had a storke. A stroke happens when blood flow to the brain is blocked and oxygen for the brain cells is insufficient, which could leads to cell death."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"History of Strokes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#StrokeHistory">https://w3id.org/timebank#StrokeHistory</seealso>
    let StrokeHistory = Prefixed_Name(tb, "StrokeHistory") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Supplies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Availability of specific supplies to complete a task."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supplies"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Supplies">https://w3id.org/timebank#Supplies</seealso>
    let Supplies = Prefixed_Name(tb, "Supplies") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Tailoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Specialized in providing tailoring services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tailoring"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Tailoring">https://w3id.org/timebank#Tailoring</seealso>
    let Tailoring = Prefixed_Name(tb, "Tailoring") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#ToiletUsingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The person has difficulties using toilet."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Toilet Using Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#ToiletUsingProblem">https://w3id.org/timebank#ToiletUsingProblem</seealso>
    let ToiletUsingProblem = Prefixed_Name(tb, "ToiletUsingProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Tools</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Tools can be provided."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tools"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Tools">https://w3id.org/timebank#Tools</seealso>
    let Tools = Prefixed_Name(tb, "Tools") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Transportation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to provide services related to transportation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"TransportationServices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Transportation">https://w3id.org/timebank#Transportation</seealso>
    let Transportation = Prefixed_Name(tb, "Transportation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#TransportationAvailable</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Transportation necessary to complete the task can be provided."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Transportation Available"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#TransportationAvailable">https://w3id.org/timebank#TransportationAvailable</seealso>
    let TransportationAvailable =
        Prefixed_Name(tb, "TransportationAvailable") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#TravelCompanion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The ability to act as a travel companion."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Travel Companion"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#TravelCompanion">https://w3id.org/timebank#TravelCompanion</seealso>
    let TravelCompanion = Prefixed_Name(tb, "TravelCompanion") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#UnevenTerrain</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The person needs equipment (e.g. shoes) suitable for uneven terrain."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Uneven Terrain"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#UnevenTerrain">https://w3id.org/timebank#UnevenTerrain</seealso>
    let UnevenTerrain = Prefixed_Name(tb, "UnevenTerrain") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#User</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A user of the Timebank."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"User"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#User">https://w3id.org/timebank#User</seealso>
    let User = Prefixed_Name(tb, "User") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#WalkingProblem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The person has difficulties walking."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Walking Problem"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WalkingProblem">https://w3id.org/timebank#WalkingProblem</seealso>
    let WalkingProblem = Prefixed_Name(tb, "WalkingProblem") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Water</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"Water outlet is available."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Water"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Water">https://w3id.org/timebank#Water</seealso>
    let Water = Prefixed_Name(tb, "Water") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#WeatherConstraint</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The place is difficult to access during bad weather (e.g. snow)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weather Constraint"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WeatherConstraint">https://w3id.org/timebank#WeatherConstraint</seealso>
    let WeatherConstraint = Prefixed_Name(tb, "WeatherConstraint") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#WoodCarving</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>"The skill to Carve items out of wood."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wood Carving"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WoodCarving">https://w3id.org/timebank#WoodCarving</seealso>
    let WoodCarving = Prefixed_Name(tb, "WoodCarving") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#WoodCrafting</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"Crafting skill with wood as base material."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Wood Crafting"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#WoodCrafting">https://w3id.org/timebank#WoodCrafting</seealso>
    let WoodCrafting = Prefixed_Name(tb, "WoodCrafting") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#Writing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Class</para>
    ///   <para>"The skill to assist with written work, like writing or reading a letter."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Writing"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#Writing">https://w3id.org/timebank#Writing</seealso>
    let Writing = Prefixed_Name(tb, "Writing") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#accepts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a user who is willing to help accepted the request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"accepts"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#accepts">https://w3id.org/timebank#accepts</seealso>
    let accepts = Prefixed_Name(tb, "accepts") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#endsRepeatingOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a time-interval is repeating until this time and date."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"ends repeating on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#endsRepeatingOn">https://w3id.org/timebank#endsRepeatingOn</seealso>
    let endsRepeatingOn = Prefixed_Name(tb, "endsRepeatingOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#excludesUserByLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to describe that a request exludes helpers having a certain limitation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"excludes user by limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#excludesUserByLimitation">https://w3id.org/timebank#excludesUserByLimitation</seealso>
    let excludesUserByLimitation =
        Prefixed_Name(tb, "excludesUserByLimitation") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#excludesUserFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property is used to describe that a certain limitation excludes certain helpers from the request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"excludes user from"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#excludesUserFrom">https://w3id.org/timebank#excludesUserFrom</seealso>
    let excludesUserFrom = Prefixed_Name(tb, "excludesUserFrom") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#hasAccreditedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has accredited duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasAccreditedDuration">https://w3id.org/timebank#hasAccreditedDuration</seealso>
    let hasAccreditedDuration =
        Prefixed_Name(tb, "hasAccreditedDuration") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#hasAddressPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An address part that describes the location of a specific request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has address part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasAddressPart">https://w3id.org/timebank#hasAddressPart</seealso>
    let hasAddressPart = Prefixed_Name(tb, "hasAddressPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain Location Specifier has a specific environmental factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasEnvironment">https://w3id.org/timebank#hasEnvironment</seealso>
    let hasEnvironment = Prefixed_Name(tb, "hasEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasExpectedDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has expected duration"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasExpectedDuration">https://w3id.org/timebank#hasExpectedDuration</seealso>
    let hasExpectedDuration = Prefixed_Name(tb, "hasExpectedDuration") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasLimitation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a Timebank user suffers from a certain limitation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has limitation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasLimitation">https://w3id.org/timebank#hasLimitation</seealso>
    let hasLimitation = Prefixed_Name(tb, "hasLimitation") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasNotEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain Location Specifier has a specific environmental factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has not environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasNotEnvironment">https://w3id.org/timebank#hasNotEnvironment</seealso>
    let hasNotEnvironment = Prefixed_Name(tb, "hasNotEnvironment") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasOriginator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the request has the specific originator."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has originator"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasOriginator">https://w3id.org/timebank#hasOriginator</seealso>
    let hasOriginator = Prefixed_Name(tb, "hasOriginator") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasSeverity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the severity of a limitation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has severity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSeverity">https://w3id.org/timebank#hasSeverity</seealso>
    let hasSeverity = Prefixed_Name(tb, "hasSeverity") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the Skill of a certain Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has skill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSkill">https://w3id.org/timebank#hasSkill</seealso>
    let hasSkill = Prefixed_Name(tb, "hasSkill") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasSkillLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the proficiency level of a skill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has skill level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSkillLevel">https://w3id.org/timebank#hasSkillLevel</seealso>
    let hasSkillLevel = Prefixed_Name(tb, "hasSkillLevel") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Every request can have at most one status assigned to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasStatus">https://w3id.org/timebank#hasStatus</seealso>
    let hasStatus = Prefixed_Name(tb, "hasStatus") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasSubPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has sub-part"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasSubPart">https://w3id.org/timebank#hasSubPart</seealso>
    let hasSubPart = Prefixed_Name(tb, "hasSubPart") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasTimeBalance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the current time-balance of a Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has time-balance"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasTimeBalance">https://w3id.org/timebank#hasTimeBalance</seealso>
    let hasTimeBalance = Prefixed_Name(tb, "hasTimeBalance") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#hasTimeWindow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time window in which the request can/should be completed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"has time window"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#hasTimeWindow">https://w3id.org/timebank#hasTimeWindow</seealso>
    let hasTimeWindow = Prefixed_Name(tb, "hasTimeWindow") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAcceptanceDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date when the Timebank request was accepted by the assigned helper."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is acceptance date of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptanceDateOf">https://w3id.org/timebank#isAcceptanceDateOf</seealso>
    let isAcceptanceDateOf = Prefixed_Name(tb, "isAcceptanceDateOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAcceptedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a request is accepted by a user who is willing to help completing the request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is accepted by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptedBy">https://w3id.org/timebank#isAcceptedBy</seealso>
    let isAcceptedBy = Prefixed_Name(tb, "isAcceptedBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAcceptedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date when the Timebank request was accepted by the assigned helper."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is accepted on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAcceptedOn">https://w3id.org/timebank#isAcceptedOn</seealso>
    let isAcceptedOn = Prefixed_Name(tb, "isAcceptedOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAccreditedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The accredited duration of the request. This is the amount of time which will be transferred from the originator the the assigned helper of the request. Do not use this property to indicate the estimated duration of the task. Use hasExpectedDuration instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is accredited to"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAccreditedTo">https://w3id.org/timebank#isAccreditedTo</seealso>
    let isAccreditedTo = Prefixed_Name(tb, "isAccreditedTo") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAdressPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An address part that describes the location of a specific request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is adress part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAdressPartOf">https://w3id.org/timebank#isAdressPartOf</seealso>
    let isAdressPartOf = Prefixed_Name(tb, "isAdressPartOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAvailabilityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the availability of a Timebank user to act as a helper for a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is availability of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAvailabilityOf">https://w3id.org/timebank#isAvailabilityOf</seealso>
    let isAvailabilityOf = Prefixed_Name(tb, "isAvailabilityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isAvailableOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the availability of a Timebank user to act as a helper for a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is available on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isAvailableOn">https://w3id.org/timebank#isAvailableOn</seealso>
    let isAvailableOn = Prefixed_Name(tb, "isAvailableOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isCancellationDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date when the Timebank request was cancelled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is cancellation date of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCancellationDateOf">https://w3id.org/timebank#isCancellationDateOf</seealso>
    let isCancellationDateOf = Prefixed_Name(tb, "isCancellationDateOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isCancelledOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date when the Timebank request was cancelled."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is cancelled on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCancelledOn">https://w3id.org/timebank#isCancelledOn</seealso>
    let isCancelledOn = Prefixed_Name(tb, "isCancelledOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isCompletedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date of the completion of a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is completed on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCompletedOn">https://w3id.org/timebank#isCompletedOn</seealso>
    let isCompletedOn = Prefixed_Name(tb, "isCompletedOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isCompletionDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date of the completion of a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is completion date of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isCompletionDateOf">https://w3id.org/timebank#isCompletionDateOf</seealso>
    let isCompletionDateOf = Prefixed_Name(tb, "isCompletionDateOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isEnvironmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain Location Specifier has a specific environmental factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is environment of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isEnvironmentOf">https://w3id.org/timebank#isEnvironmentOf</seealso>
    let isEnvironmentOf = Prefixed_Name(tb, "isEnvironmentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isExpectedDurationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The expected duration indicates the duraction of the request estimated by the originator of the request. Do not use this property to assert the actual time credits associated to this request. Use hasAccreditedDuration instead."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is expected duration of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isExpectedDurationOf">https://w3id.org/timebank#isExpectedDurationOf</seealso>
    let isExpectedDurationOf = Prefixed_Name(tb, "isExpectedDurationOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isLimitationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain limitation applies to the Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is limitation of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isLimitationOf">https://w3id.org/timebank#isLimitationOf</seealso>
    let isLimitationOf = Prefixed_Name(tb, "isLimitationOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isNotEnvironmentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a certain Location Specifier has a specific environmental factor."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is not environment of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isNotEnvironmentOf">https://w3id.org/timebank#isNotEnvironmentOf</seealso>
    let isNotEnvironmentOf = Prefixed_Name(tb, "isNotEnvironmentOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isOriginatorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the user is the originator of the request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is originator of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isOriginatorOf">https://w3id.org/timebank#isOriginatorOf</seealso>
    let isOriginatorOf = Prefixed_Name(tb, "isOriginatorOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isPublicationDateOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date of the publication of a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is publication date of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isPublicationDateOf">https://w3id.org/timebank#isPublicationDateOf</seealso>
    let isPublicationDateOf = Prefixed_Name(tb, "isPublicationDateOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isPublishedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time and date of the publication of a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is published on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isPublishedOn">https://w3id.org/timebank#isPublishedOn</seealso>
    let isPublishedOn = Prefixed_Name(tb, "isPublishedOn") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#isRepeatingEndpointOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a specific time and date marks the end of a repetition of a time-interval."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is repeating endpoint of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRepeatingEndpointOf">https://w3id.org/timebank#isRepeatingEndpointOf</seealso>
    let isRepeatingEndpointOf =
        Prefixed_Name(tb, "isRepeatingEndpointOf") |> PrefixedName

    /// <summary>
    ///   <para>w3id:timebank#isRepetitionDayOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a time interval repeats on the specified weekdays."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is repetition date of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRepetitionDayOf">https://w3id.org/timebank#isRepetitionDayOf</seealso>
    let isRepetitionDayOf = Prefixed_Name(tb, "isRepetitionDayOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isRequiredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The skill associated with a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is required by"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isRequiredBy">https://w3id.org/timebank#isRequiredBy</seealso>
    let isRequiredBy = Prefixed_Name(tb, "isRequiredBy") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isSeverityOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the severity of a limitation."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is severity of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSeverityOf">https://w3id.org/timebank#isSeverityOf</seealso>
    let isSeverityOf = Prefixed_Name(tb, "isSeverityOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isSkillLevelOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the proficiency level of a skill."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is skill level of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSkillLevelOf">https://w3id.org/timebank#isSkillLevelOf</seealso>
    let isSkillLevelOf = Prefixed_Name(tb, "isSkillLevelOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isSkillOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes the Skill of a certain Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is skill of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSkillOf">https://w3id.org/timebank#isSkillOf</seealso>
    let isSkillOf = Prefixed_Name(tb, "isSkillOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isStatusOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Every request can have at most one status assigned to it."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is status of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isStatusOf">https://w3id.org/timebank#isStatusOf</seealso>
    let isStatusOf = Prefixed_Name(tb, "isStatusOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isSubPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that the address part is a sub-part of another. A sub-part defines a place more precisely. A sub-part is always in the context of its super-part. For example, a streetnumber is a sub- part of the street."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is sub-part of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isSubPartOf">https://w3id.org/timebank#isSubPartOf</seealso>
    let isSubPartOf = Prefixed_Name(tb, "isSubPartOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isTimeBalanceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the current time-balance of a Timebank user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is time-balance of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isTimeBalanceOf">https://w3id.org/timebank#isTimeBalanceOf</seealso>
    let isTimeBalanceOf = Prefixed_Name(tb, "isTimeBalanceOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#isTimeWindowOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates the time window in which the request can/should be completed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"is time window of"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#isTimeWindowOf">https://w3id.org/timebank#isTimeWindowOf</seealso>
    let isTimeWindowOf = Prefixed_Name(tb, "isTimeWindowOf") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The rating given by the originator of a request to the assigned helper for completing the specific request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"rating"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#rating">https://w3id.org/timebank#rating</seealso>
    let rating = Prefixed_Name(tb, "rating") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#repeatsOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indicates that a time interval repeats on the specified weekdays."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"repeats on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#repeatsOn">https://w3id.org/timebank#repeatsOn</seealso>
    let repeatsOn = Prefixed_Name(tb, "repeatsOn") |> PrefixedName
    /// <summary>
    ///   <para>w3id:timebank#requiresSkill</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The skill associated with a Timebank request."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"requires skill"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="https://w3id.org/timebank#requiresSkill">https://w3id.org/timebank#requiresSkill</seealso>
    let requiresSkill = Prefixed_Name(tb, "requiresSkill") |> PrefixedName
