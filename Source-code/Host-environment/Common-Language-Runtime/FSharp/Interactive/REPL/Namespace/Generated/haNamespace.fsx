#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ha =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://sensormeasurement.appspot.com/ont/home/homeActivity#" "ha"

    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:label : ADL^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ADL">ha:ADL</a>
    /// </summary>
    let ADL = _prefixId.prefix "ADL"
    /// <summary>
    ///   <para>rdfs:label : Activity_Log^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Activity_Log">ha:Activity_Log</a>
    /// </summary>
    let Activity_Log = _prefixId.prefix "Activity_Log"
    /// <summary>
    ///   <para>rdfs:label : Alcolhol^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Alcolhol">ha:Alcolhol</a>
    /// </summary>
    let Alcolhol = _prefixId.prefix "Alcolhol"
    /// <summary>
    ///   <para>rdfs:label : Any^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Any">ha:Any</a>
    /// </summary>
    let Any = _prefixId.prefix "Any"
    /// <summary>
    ///   <para>rdfs:label : Bathroom^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom">ha:Bathroom</a>
    /// </summary>
    let Bathroom = _prefixId.prefix "Bathroom"
    /// <summary>
    ///   <para>rdfs:label : Bathroom_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom_Activity">ha:Bathroom_Activity</a>
    /// </summary>
    let Bathroom_Activity = _prefixId.prefix "Bathroom_Activity"
    /// <summary>
    ///   <para>rdfs:label : Bed^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bed">ha:Bed</a>
    /// </summary>
    let Bed = _prefixId.prefix "Bed"
    /// <summary>
    ///   <para>rdfs:label : Bedroom^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom">ha:Bedroom</a>
    /// </summary>
    let Bedroom = _prefixId.prefix "Bedroom"
    /// <summary>
    ///   <para>rdfs:label : Bedroom_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom_Activity">ha:Bedroom_Activity</a>
    /// </summary>
    let Bedroom_Activity = _prefixId.prefix "Bedroom_Activity"
    /// <summary>
    ///   <para>rdfs:label : Book^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Book">ha:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : Bottle^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bottle">ha:Bottle</a>
    /// </summary>
    let Bottle = _prefixId.prefix "Bottle"
    /// <summary>
    ///   <para>rdfs:label : Broom^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Broom">ha:Broom</a>
    /// </summary>
    let Broom = _prefixId.prefix "Broom"
    /// <summary>
    ///   <para>rdfs:label : Chair^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Chair">ha:Chair</a>
    /// </summary>
    let Chair = _prefixId.prefix "Chair"
    /// <summary>
    ///   <para>rdfs:label : Coffee^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Coffee">ha:Coffee</a>
    /// </summary>
    let Coffee = _prefixId.prefix "Coffee"
    /// <summary>
    ///   <para>rdfs:label : Computer^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Computer">ha:Computer</a>
    /// </summary>
    let Computer = _prefixId.prefix "Computer"
    /// <summary>
    ///   <para>rdfs:label : Context^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Context">ha:Context</a>
    /// </summary>
    let Context = _prefixId.prefix "Context"
    /// <summary>
    ///   <para>rdfs:label : Cooking^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cooking">ha:Cooking</a>
    /// </summary>
    let Cooking = _prefixId.prefix "Cooking"
    /// <summary>
    ///   <para>rdfs:label : Cupboard^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cupboard">ha:Cupboard</a>
    /// </summary>
    let Cupboard = _prefixId.prefix "Cupboard"
    /// <summary>
    ///   <para>rdfs:label : Current_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Current_Sensor">ha:Current_Sensor</a>
    /// </summary>
    let Current_Sensor = _prefixId.prefix "Current_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Date">ha:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:label : Door^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Door">ha:Door</a>
    /// </summary>
    let Door = _prefixId.prefix "Door"
    /// <summary>
    ///   <para>rdfs:label : Drink^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Drink">ha:Drink</a>
    /// </summary>
    let Drink = _prefixId.prefix "Drink"
    /// <summary>
    ///   <para>rdfs:label : Eating_or_drinking^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Eating_or_drinking">ha:Eating_or_drinking</a>
    /// </summary>
    let Eating_or_drinking = _prefixId.prefix "Eating_or_drinking"
    /// <summary>
    ///   <para>rdfs:label : Electric_Appliance^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Appliance">ha:Electric_Appliance</a>
    /// </summary>
    let Electric_Appliance = _prefixId.prefix "Electric_Appliance"
    /// <summary>
    ///   <para>rdfs:label : Electric_Stove^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Stove">ha:Electric_Stove</a>
    /// </summary>
    let Electric_Stove = _prefixId.prefix "Electric_Stove"
    /// <summary>
    ///   <para>rdfs:label : Entertainment^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Entertainment">ha:Entertainment</a>
    /// </summary>
    let Entertainment = _prefixId.prefix "Entertainment"
    /// <summary>
    ///   <para>rdfs:label : Food^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Food">ha:Food</a>
    /// </summary>
    let Food = _prefixId.prefix "Food"
    /// <summary>
    ///   <para>rdfs:label : Functional_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Functional_Activity">ha:Functional_Activity</a>
    /// </summary>
    let Functional_Activity = _prefixId.prefix "Functional_Activity"
    /// <summary>
    ///   <para>rdfs:label : Furniture^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Furniture">ha:Furniture</a>
    /// </summary>
    let Furniture = _prefixId.prefix "Furniture"
    /// <summary>
    ///   <para>rdfs:label : Gyro_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Gyro_Sensor">ha:Gyro_Sensor</a>
    /// </summary>
    let Gyro_Sensor = _prefixId.prefix "Gyro_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Human^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human">ha:Human</a>
    /// </summary>
    let Human = _prefixId.prefix "Human"
    /// <summary>
    ///   <para>rdfs:label : Human_Posture^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human_Posture">ha:Human_Posture</a>
    /// </summary>
    let Human_Posture = _prefixId.prefix "Human_Posture"
    /// <summary>
    ///   <para>rdfs:label : InferredActivity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#InferredActivity">ha:InferredActivity</a>
    /// </summary>
    let InferredActivity = _prefixId.prefix "InferredActivity"
    /// <summary>
    ///   <para>rdfs:label : Infrared_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Infrared_Sensor">ha:Infrared_Sensor</a>
    /// </summary>
    let Infrared_Sensor = _prefixId.prefix "Infrared_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Juice^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Juice">ha:Juice</a>
    /// </summary>
    let Juice = _prefixId.prefix "Juice"
    /// <summary>
    ///   <para>rdfs:label : Kettle^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kettle">ha:Kettle</a>
    /// </summary>
    let Kettle = _prefixId.prefix "Kettle"
    /// <summary>
    ///   <para>rdfs:label : Kitchen^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen">ha:Kitchen</a>
    /// </summary>
    let Kitchen = _prefixId.prefix "Kitchen"
    /// <summary>
    ///   <para>rdfs:label : Kitchen_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Activity">ha:Kitchen_Activity</a>
    /// </summary>
    let Kitchen_Activity = _prefixId.prefix "Kitchen_Activity"
    /// <summary>
    ///   <para>rdfs:label : Kitchen_Appliance^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Appliance">ha:Kitchen_Appliance</a>
    /// </summary>
    let Kitchen_Appliance = _prefixId.prefix "Kitchen_Appliance"
    /// <summary>
    ///   <para>rdfs:label : Last_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Activity">ha:Last_Activity</a>
    /// </summary>
    let Last_Activity = _prefixId.prefix "Last_Activity"
    /// <summary>
    ///   <para>rdfs:label : Last_Object^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Object">ha:Last_Object</a>
    /// </summary>
    let Last_Object = _prefixId.prefix "Last_Object"
    /// <summary>
    ///   <para>rdfs:label : Lavatory^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lavatory">ha:Lavatory</a>
    /// </summary>
    let Lavatory = _prefixId.prefix "Lavatory"
    /// <summary>
    ///   <para>rdfs:label : Lie-down^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lie-down">ha:Lie-down</a>
    /// </summary>
    let Lie_down = _prefixId.prefix "Lie-down"
    /// <summary>
    ///   <para>rdfs:label : Living_room_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Living_room_Activity">ha:Living_room_Activity</a>
    /// </summary>
    let Living_room_Activity = _prefixId.prefix "Living_room_Activity"
    /// <summary>
    ///   <para>rdfs:label : Livingroom^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Livingroom">ha:Livingroom</a>
    /// </summary>
    let Livingroom = _prefixId.prefix "Livingroom"
    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location">ha:Location</a>
    /// </summary>
    let Location = _prefixId.prefix "Location"
    /// <summary>
    ///   <para>rdfs:label : Location_based_Activity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location_based_Activity">ha:Location_based_Activity</a>
    /// </summary>
    let Location_based_Activity = _prefixId.prefix "Location_based_Activity"
    /// <summary>
    ///   <para>rdfs:label : Lying_down___relaxing^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lying_down___relaxing">ha:Lying_down___relaxing</a>
    /// </summary>
    let Lying_down___relaxing = _prefixId.prefix "Lying_down___relaxing"
    /// <summary>
    ///   <para>rdfs:label : Magnetic_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Magnetic_Sensor">ha:Magnetic_Sensor</a>
    /// </summary>
    let Magnetic_Sensor = _prefixId.prefix "Magnetic_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Making_a_coffee^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Making_a_coffee">ha:Making_a_coffee</a>
    /// </summary>
    let Making_a_coffee = _prefixId.prefix "Making_a_coffee"
    /// <summary>
    ///   <para>rdfs:label : Microwave^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Microwave">ha:Microwave</a>
    /// </summary>
    let Microwave = _prefixId.prefix "Microwave"
    /// <summary>
    ///   <para>rdfs:label : Milk^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Milk">ha:Milk</a>
    /// </summary>
    let Milk = _prefixId.prefix "Milk"
    /// <summary>
    ///   <para>rdfs:label : Mop^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Mop">ha:Mop</a>
    /// </summary>
    let Mop = _prefixId.prefix "Mop"
    /// <summary>
    ///   <para>rdfs:label : Object^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object">ha:Object</a>
    /// </summary>
    let Object = _prefixId.prefix "Object"
    /// <summary>
    ///   <para>rdfs:label : ObjectInstance^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ObjectInstance">ha:ObjectInstance</a>
    /// </summary>
    let ObjectInstance = _prefixId.prefix "ObjectInstance"
    /// <summary>
    ///   <para>rdfs:label : Object_based_Actvity^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object_based_Actvity">ha:Object_based_Actvity</a>
    /// </summary>
    let Object_based_Actvity = _prefixId.prefix "Object_based_Actvity"
    /// <summary>
    ///   <para>rdfs:label : Oven^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Oven">ha:Oven</a>
    /// </summary>
    let Oven = _prefixId.prefix "Oven"
    /// <summary>
    ///   <para>rdfs:label : Phone^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Phone">ha:Phone</a>
    /// </summary>
    let Phone = _prefixId.prefix "Phone"
    /// <summary>
    ///   <para>rdfs:label : Pressure_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Pressure_Sensor">ha:Pressure_Sensor</a>
    /// </summary>
    let Pressure_Sensor = _prefixId.prefix "Pressure_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Reading_a_book^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Reading_a_book">ha:Reading_a_book</a>
    /// </summary>
    let Reading_a_book = _prefixId.prefix "Reading_a_book"
    /// <summary>
    ///   <para>rdfs:label : Refrigerator^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Refrigerator">ha:Refrigerator</a>
    /// </summary>
    let Refrigerator = _prefixId.prefix "Refrigerator"
    /// <summary>
    ///   <para>rdfs:label : RelationalConcept^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#RelationalConcept">ha:RelationalConcept</a>
    /// </summary>
    let RelationalConcept = _prefixId.prefix "RelationalConcept"
    /// <summary>
    ///   <para>rdfs:label : Scrubbing_the_floor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Scrubbing_the_floor">ha:Scrubbing_the_floor</a>
    /// </summary>
    let Scrubbing_the_floor = _prefixId.prefix "Scrubbing_the_floor"
    /// <summary>
    ///   <para>rdfs:label : Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor">ha:Sensor</a>
    /// </summary>
    let Sensor = _prefixId.prefix "Sensor"
    /// <summary>
    ///   <para>rdfs:label : Sensor_Type^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor_Type">ha:Sensor_Type</a>
    /// </summary>
    let Sensor_Type = _prefixId.prefix "Sensor_Type"
    /// <summary>
    ///   <para>rdfs:label : Shower^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Shower">ha:Shower</a>
    /// </summary>
    let Shower = _prefixId.prefix "Shower"
    /// <summary>
    ///   <para>rdfs:label : Sink^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sink">ha:Sink</a>
    /// </summary>
    let Sink = _prefixId.prefix "Sink"
    /// <summary>
    ///   <para>rdfs:label : Sit^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sit">ha:Sit</a>
    /// </summary>
    let Sit = _prefixId.prefix "Sit"
    /// <summary>
    ///   <para>rdfs:label : Sitting_on_the_toilet^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sitting_on_the_toilet">ha:Sitting_on_the_toilet</a>
    /// </summary>
    let Sitting_on_the_toilet = _prefixId.prefix "Sitting_on_the_toilet"
    /// <summary>
    ///   <para>rdfs:label : Sleeping^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sleeping">ha:Sleeping</a>
    /// </summary>
    let Sleeping = _prefixId.prefix "Sleeping"
    /// <summary>
    ///   <para>rdfs:label : Sofa^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sofa">ha:Sofa</a>
    /// </summary>
    let Sofa = _prefixId.prefix "Sofa"
    /// <summary>
    ///   <para>rdfs:label : Softdrink^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Softdrink">ha:Softdrink</a>
    /// </summary>
    let Softdrink = _prefixId.prefix "Softdrink"
    /// <summary>
    ///   <para>rdfs:label : Stand^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stand">ha:Stand</a>
    /// </summary>
    let Stand = _prefixId.prefix "Stand"
    /// <summary>
    ///   <para>rdfs:label : Stereo^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stereo">ha:Stereo</a>
    /// </summary>
    let Stereo = _prefixId.prefix "Stereo"
    /// <summary>
    ///   <para>rdfs:label : Sugar^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sugar">ha:Sugar</a>
    /// </summary>
    let Sugar = _prefixId.prefix "Sugar"
    /// <summary>
    ///   <para>rdfs:label : Sweeping_the_floor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sweeping_the_floor">ha:Sweeping_the_floor</a>
    /// </summary>
    let Sweeping_the_floor = _prefixId.prefix "Sweeping_the_floor"
    /// <summary>
    ///   <para>rdfs:label : TV^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#TV">ha:TV</a>
    /// </summary>
    let TV = _prefixId.prefix "TV"
    /// <summary>
    ///   <para>rdfs:label : Table^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Table">ha:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : Taking_a_bath^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Taking_a_bath">ha:Taking_a_bath</a>
    /// </summary>
    let Taking_a_bath = _prefixId.prefix "Taking_a_bath"
    /// <summary>
    ///   <para>rdfs:label : Tea^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Tea">ha:Tea</a>
    /// </summary>
    let Tea = _prefixId.prefix "Tea"
    /// <summary>
    ///   <para>rdfs:label : Ultrasonic_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Ultrasonic_Sensor">ha:Ultrasonic_Sensor</a>
    /// </summary>
    let Ultrasonic_Sensor = _prefixId.prefix "Ultrasonic_Sensor"
    /// <summary>
    ///   <para>rdfs:label : UndefinedClass^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#UndefinedClass">ha:UndefinedClass</a>
    /// </summary>
    let UndefinedClass = _prefixId.prefix "UndefinedClass"
    /// <summary>
    ///   <para>rdfs:label : Wash_dishes^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Wash_dishes">ha:Wash_dishes</a>
    /// </summary>
    let Wash_dishes = _prefixId.prefix "Wash_dishes"
    /// <summary>
    ///   <para>rdfs:label : Watching_TV^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Watching_TV">ha:Watching_TV</a>
    /// </summary>
    let Watching_TV = _prefixId.prefix "Watching_TV"
    /// <summary>
    ///   <para>rdfs:label : Water_Meter_Sensor^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Water_Meter_Sensor">ha:Water_Meter_Sensor</a>
    /// </summary>
    let Water_Meter_Sensor = _prefixId.prefix "Water_Meter_Sensor"
    /// <summary>
    ///   <para>rdfs:label : Working_on_computer^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Working_on_computer">ha:Working_on_computer</a>
    /// </summary>
    let Working_on_computer = _prefixId.prefix "Working_on_computer"
    /// <summary>
    ///   <para>rdfs:label : hasAttribute^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasAttribute">ha:hasAttribute</a>
    /// </summary>
    let hasAttribute = _prefixId.prefix "hasAttribute"
    /// <summary>
    ///   <para>rdfs:label : hasPart^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasPart">ha:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    let has_Activity_ID = _prefixId.prefix "has_Activity_ID"
    let has_Activity_name = _prefixId.prefix "has_Activity_name"
    let has_Actor = _prefixId.prefix "has_Actor"
    let has_AttachTo = _prefixId.prefix "has_AttachTo"
    let has_Collect = _prefixId.prefix "has_Collect"
    let has_Combine_with = _prefixId.prefix "has_Combine_with"
    let has_Context_ID = _prefixId.prefix "has_Context_ID"
    let has_Current_location = _prefixId.prefix "has_Current_location"
    let has_Day_of_week = _prefixId.prefix "has_Day_of_week"
    let has_Have_activity = _prefixId.prefix "has_Have_activity"
    let has_Location_ID = _prefixId.prefix "has_Location_ID"
    let has_Location_name = _prefixId.prefix "has_Location_name"
    let has_Month = _prefixId.prefix "has_Month"
    let has_Object_ID = _prefixId.prefix "has_Object_ID"
    let has_Object_info = _prefixId.prefix "has_Object_info"
    let has_Object_name = _prefixId.prefix "has_Object_name"
    let has_Posture_ID = _prefixId.prefix "has_Posture_ID"
    let has_Posture_name = _prefixId.prefix "has_Posture_name"
    let has_Sensor_ID = _prefixId.prefix "has_Sensor_ID"
    let has_Status = _prefixId.prefix "has_Status"
    let has_Time = _prefixId.prefix "has_Time"
    let has_Year = _prefixId.prefix "has_Year"
    let has_date = _prefixId.prefix "has_date"
    let has_hasDrinkType = _prefixId.prefix "has_hasDrinkType"
    let has_hasFood = _prefixId.prefix "has_hasFood"
    let has_hasPosture = _prefixId.prefix "has_hasPosture"
    let has_have_act_log = _prefixId.prefix "has_have_act_log"
    let has_have_activities = _prefixId.prefix "has_have_activities"
    let has_have_date = _prefixId.prefix "has_have_date"
    let has_have_hum_pos = _prefixId.prefix "has_have_hum_pos"
    let has_have_inf_activity = _prefixId.prefix "has_have_inf_activity"
    let has_have_last_activity = _prefixId.prefix "has_have_last_activity"
    let has_have_last_object = _prefixId.prefix "has_have_last_object"
    let has_have_obj = _prefixId.prefix "has_have_obj"
    let has_have_sensor = _prefixId.prefix "has_have_sensor"
    let has_have_time = _prefixId.prefix "has_have_time"
    let has_id = _prefixId.prefix "has_id"
    let has_isAttached = _prefixId.prefix "has_isAttached"
    let has_location = _prefixId.prefix "has_location"
    let has_location_concept = _prefixId.prefix "has_location_concept"
    let has_name = _prefixId.prefix "has_name"
    let has_obj_inst_id = _prefixId.prefix "has_obj_inst_id"
    let has_object = _prefixId.prefix "has_object"
    let has_posture = _prefixId.prefix "has_posture"
    let has_rec_act_id = _prefixId.prefix "has_rec_act_id"
    let has_rec_act_name = _prefixId.prefix "has_rec_act_name"
    let has_use = _prefixId.prefix "has_use"
    /// <summary>
    ///   <para>rdfs:label : integer^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#integer">ha:integer</a>
    /// </summary>
    let integer = _prefixId.prefix "integer"
    /// <summary>
    ///   <para>rdfs:label : string^^xsd:string</para>
    ///   <a href="http://sensormeasurement.appspot.com/ont/home/homeActivity#string">ha:string</a>
    /// </summary>
    let string = _prefixId.prefix "string"
