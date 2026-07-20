namespace http.sensormeasurement.appspot.com.ont.home.homeActivity.hash

open DoxAletheia

module ha =
    let _namespace_name = "http://sensormeasurement.appspot.com/ont/home/homeActivity#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ADL"></see>
    /// </summary>
    let ADL = _prefix "ADL"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_date"></see>
    /// </summary>
    let has_have_date = _prefix "has_have_date"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#string"></see>
    /// </summary>
    let string = _prefix "string"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Time"></see>
    /// </summary>
    let has_Time = _prefix "has_Time"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Date"></see>
    /// </summary>
    let Date = _prefix "Date"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Activity"></see>
    /// </summary>
    let Last_Activity = _prefix "Last_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Collect"></see>
    /// </summary>
    let has_Collect = _prefix "has_Collect"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Any"></see>
    /// </summary>
    let Any = _prefix "Any"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Activity_Log"></see>
    /// </summary>
    let Activity_Log = _prefix "Activity_Log"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Alcolhol"></see>
    /// </summary>
    let Alcolhol = _prefix "Alcolhol"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Drink"></see>
    /// </summary>
    let Drink = _prefix "Drink"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom"></see>
    /// </summary>
    let Bathroom = _prefix "Bathroom"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location"></see>
    /// </summary>
    let Location = _prefix "Location"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom_Activity"></see>
    /// </summary>
    let Bathroom_Activity = _prefix "Bathroom_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location"></see>
    /// </summary>
    let has_location = _prefix "has_location"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location_based_Activity"></see>
    /// </summary>
    let Location_based_Activity = _prefix "Location_based_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bed"></see>
    /// </summary>
    let Bed = _prefix "Bed"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Furniture"></see>
    /// </summary>
    let Furniture = _prefix "Furniture"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom"></see>
    /// </summary>
    let Bedroom = _prefix "Bedroom"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom_Activity"></see>
    /// </summary>
    let Bedroom_Activity = _prefix "Bedroom_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Book"></see>
    /// </summary>
    let Book = _prefix "Book"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bottle"></see>
    /// </summary>
    let Bottle = _prefix "Bottle"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Broom"></see>
    /// </summary>
    let Broom = _prefix "Broom"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Chair"></see>
    /// </summary>
    let Chair = _prefix "Chair"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Coffee"></see>
    /// </summary>
    let Coffee = _prefix "Coffee"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Computer"></see>
    /// </summary>
    let Computer = _prefix "Computer"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Entertainment"></see>
    /// </summary>
    let Entertainment = _prefix "Entertainment"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Context"></see>
    /// </summary>
    let Context = _prefix "Context"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_sensor"></see>
    /// </summary>
    let has_have_sensor = _prefix "has_have_sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor"></see>
    /// </summary>
    let Sensor = _prefix "Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human_Posture"></see>
    /// </summary>
    let Human_Posture = _prefix "Human_Posture"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_hum_pos"></see>
    /// </summary>
    let has_have_hum_pos = _prefix "has_have_hum_pos"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_inf_activity"></see>
    /// </summary>
    let has_have_inf_activity = _prefix "has_have_inf_activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Object"></see>
    /// </summary>
    let Last_Object = _prefix "Last_Object"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_object"></see>
    /// </summary>
    let has_have_last_object = _prefix "has_have_last_object"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_activity"></see>
    /// </summary>
    let has_have_last_activity = _prefix "has_have_last_activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#integer"></see>
    /// </summary>
    let integer = _prefix "integer"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Context_ID"></see>
    /// </summary>
    let has_Context_ID = _prefix "has_Context_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_time"></see>
    /// </summary>
    let has_have_time = _prefix "has_have_time"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ObjectInstance"></see>
    /// </summary>
    let ObjectInstance = _prefix "ObjectInstance"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_obj"></see>
    /// </summary>
    let has_have_obj = _prefix "has_have_obj"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#InferredActivity"></see>
    /// </summary>
    let InferredActivity = _prefix "InferredActivity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cooking"></see>
    /// </summary>
    let Cooking = _prefix "Cooking"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Stove"></see>
    /// </summary>
    let Electric_Stove = _prefix "Electric_Stove"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_use"></see>
    /// </summary>
    let has_use = _prefix "has_use"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Refrigerator"></see>
    /// </summary>
    let Refrigerator = _prefix "Refrigerator"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Activity"></see>
    /// </summary>
    let Kitchen_Activity = _prefix "Kitchen_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cupboard"></see>
    /// </summary>
    let Cupboard = _prefix "Cupboard"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Current_Sensor"></see>
    /// </summary>
    let Current_Sensor = _prefix "Current_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor_Type"></see>
    /// </summary>
    let Sensor_Type = _prefix "Sensor_Type"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Year"></see>
    /// </summary>
    let has_Year = _prefix "has_Year"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_date"></see>
    /// </summary>
    let has_date = _prefix "has_date"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Month"></see>
    /// </summary>
    let has_Month = _prefix "has_Month"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Day_of_week"></see>
    /// </summary>
    let has_Day_of_week = _prefix "has_Day_of_week"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Door"></see>
    /// </summary>
    let Door = _prefix "Door"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Food"></see>
    /// </summary>
    let Food = _prefix "Food"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Eating_or_drinking"></see>
    /// </summary>
    let Eating_or_drinking = _prefix "Eating_or_drinking"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sit"></see>
    /// </summary>
    let Sit = _prefix "Sit"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasPosture"></see>
    /// </summary>
    let has_hasPosture = _prefix "has_hasPosture"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasFood"></see>
    /// </summary>
    let has_hasFood = _prefix "has_hasFood"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Appliance"></see>
    /// </summary>
    let Electric_Appliance = _prefix "Electric_Appliance"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Appliance"></see>
    /// </summary>
    let Kitchen_Appliance = _prefix "Kitchen_Appliance"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Functional_Activity"></see>
    /// </summary>
    let Functional_Activity = _prefix "Functional_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_name"></see>
    /// </summary>
    let has_name = _prefix "has_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_id"></see>
    /// </summary>
    let has_id = _prefix "has_id"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Gyro_Sensor"></see>
    /// </summary>
    let Gyro_Sensor = _prefix "Gyro_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human"></see>
    /// </summary>
    let Human = _prefix "Human"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_act_log"></see>
    /// </summary>
    let has_have_act_log = _prefix "has_have_act_log"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_name"></see>
    /// </summary>
    let has_Posture_name = _prefix "has_Posture_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_ID"></see>
    /// </summary>
    let has_Posture_ID = _prefix "has_Posture_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Actor"></see>
    /// </summary>
    let has_Actor = _prefix "has_Actor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_name"></see>
    /// </summary>
    let has_rec_act_name = _prefix "has_rec_act_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_id"></see>
    /// </summary>
    let has_rec_act_id = _prefix "has_rec_act_id"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Have_activity"></see>
    /// </summary>
    let has_Have_activity = _prefix "has_Have_activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Infrared_Sensor"></see>
    /// </summary>
    let Infrared_Sensor = _prefix "Infrared_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Juice"></see>
    /// </summary>
    let Juice = _prefix "Juice"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kettle"></see>
    /// </summary>
    let Kettle = _prefix "Kettle"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen"></see>
    /// </summary>
    let Kitchen = _prefix "Kitchen"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_activities"></see>
    /// </summary>
    let has_have_activities = _prefix "has_have_activities"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_ID"></see>
    /// </summary>
    let has_Activity_ID = _prefix "has_Activity_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location_concept"></see>
    /// </summary>
    let has_location_concept = _prefix "has_location_concept"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_name"></see>
    /// </summary>
    let has_Activity_name = _prefix "has_Activity_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_name"></see>
    /// </summary>
    let has_Object_name = _prefix "has_Object_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_info"></see>
    /// </summary>
    let has_Object_info = _prefix "has_Object_info"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_ID"></see>
    /// </summary>
    let has_Object_ID = _prefix "has_Object_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lavatory"></see>
    /// </summary>
    let Lavatory = _prefix "Lavatory"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lie-down"></see>
    /// </summary>
    let ``Lie-down`` = _prefix "Lie-down"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Living_room_Activity"></see>
    /// </summary>
    let Living_room_Activity = _prefix "Living_room_Activity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Livingroom"></see>
    /// </summary>
    let Livingroom = _prefix "Livingroom"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_name"></see>
    /// </summary>
    let has_Location_name = _prefix "has_Location_name"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_ID"></see>
    /// </summary>
    let has_Location_ID = _prefix "has_Location_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object_based_Actvity"></see>
    /// </summary>
    let Object_based_Actvity = _prefix "Object_based_Actvity"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Combine_with"></see>
    /// </summary>
    let has_Combine_with = _prefix "has_Combine_with"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lying_down___relaxing"></see>
    /// </summary>
    let Lying_down___relaxing = _prefix "Lying_down___relaxing"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sofa"></see>
    /// </summary>
    let Sofa = _prefix "Sofa"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_posture"></see>
    /// </summary>
    let has_posture = _prefix "has_posture"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Magnetic_Sensor"></see>
    /// </summary>
    let Magnetic_Sensor = _prefix "Magnetic_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Making_a_coffee"></see>
    /// </summary>
    let Making_a_coffee = _prefix "Making_a_coffee"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasDrinkType"></see>
    /// </summary>
    let has_hasDrinkType = _prefix "has_hasDrinkType"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Microwave"></see>
    /// </summary>
    let Microwave = _prefix "Microwave"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Milk"></see>
    /// </summary>
    let Milk = _prefix "Milk"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Mop"></see>
    /// </summary>
    let Mop = _prefix "Mop"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_isAttached"></see>
    /// </summary>
    let has_isAttached = _prefix "has_isAttached"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Current_location"></see>
    /// </summary>
    let has_Current_location = _prefix "has_Current_location"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_obj_inst_id"></see>
    /// </summary>
    let has_obj_inst_id = _prefix "has_obj_inst_id"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_object"></see>
    /// </summary>
    let has_object = _prefix "has_object"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Oven"></see>
    /// </summary>
    let Oven = _prefix "Oven"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Phone"></see>
    /// </summary>
    let Phone = _prefix "Phone"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Pressure_Sensor"></see>
    /// </summary>
    let Pressure_Sensor = _prefix "Pressure_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Reading_a_book"></see>
    /// </summary>
    let Reading_a_book = _prefix "Reading_a_book"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#RelationalConcept"></see>
    /// </summary>
    let RelationalConcept = _prefix "RelationalConcept"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Scrubbing_the_floor"></see>
    /// </summary>
    let Scrubbing_the_floor = _prefix "Scrubbing_the_floor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Sensor_ID"></see>
    /// </summary>
    let has_Sensor_ID = _prefix "has_Sensor_ID"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_AttachTo"></see>
    /// </summary>
    let has_AttachTo = _prefix "has_AttachTo"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Status"></see>
    /// </summary>
    let has_Status = _prefix "has_Status"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Shower"></see>
    /// </summary>
    let Shower = _prefix "Shower"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sink"></see>
    /// </summary>
    let Sink = _prefix "Sink"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sitting_on_the_toilet"></see>
    /// </summary>
    let Sitting_on_the_toilet = _prefix "Sitting_on_the_toilet"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sleeping"></see>
    /// </summary>
    let Sleeping = _prefix "Sleeping"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Softdrink"></see>
    /// </summary>
    let Softdrink = _prefix "Softdrink"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stand"></see>
    /// </summary>
    let Stand = _prefix "Stand"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stereo"></see>
    /// </summary>
    let Stereo = _prefix "Stereo"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sugar"></see>
    /// </summary>
    let Sugar = _prefix "Sugar"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sweeping_the_floor"></see>
    /// </summary>
    let Sweeping_the_floor = _prefix "Sweeping_the_floor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#TV"></see>
    /// </summary>
    let TV = _prefix "TV"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Table"></see>
    /// </summary>
    let Table = _prefix "Table"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Taking_a_bath"></see>
    /// </summary>
    let Taking_a_bath = _prefix "Taking_a_bath"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Tea"></see>
    /// </summary>
    let Tea = _prefix "Tea"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Ultrasonic_Sensor"></see>
    /// </summary>
    let Ultrasonic_Sensor = _prefix "Ultrasonic_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#UndefinedClass"></see>
    /// </summary>
    let UndefinedClass = _prefix "UndefinedClass"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Wash_dishes"></see>
    /// </summary>
    let Wash_dishes = _prefix "Wash_dishes"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Watching_TV"></see>
    /// </summary>
    let Watching_TV = _prefix "Watching_TV"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Water_Meter_Sensor"></see>
    /// </summary>
    let Water_Meter_Sensor = _prefix "Water_Meter_Sensor"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Working_on_computer"></see>
    /// </summary>
    let Working_on_computer = _prefix "Working_on_computer"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasAttribute"></see>
    /// </summary>
    let hasAttribute = _prefix "hasAttribute"
    /// <summary>
    ///   <see href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
