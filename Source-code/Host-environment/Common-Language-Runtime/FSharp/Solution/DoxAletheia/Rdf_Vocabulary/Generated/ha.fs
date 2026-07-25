namespace http.sensormeasurement.appspot.com.ont.home.homeActivity.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ha =
    let _namespace_iri = Namespace_Iri ha |> NamespaceIRI
    /// <summary>
    ///   <para>ha:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:NamedIndividual</para>
    ///   <para>owl:Ontology</para>
    ///   <para>voaf:Vocabulary</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#">http://sensormeasurement.appspot.com/ont/home/homeActivity#</seealso>
    let _prefix_iri = Prefixed_Name(ha, "") |> PrefixedName
    /// <summary>
    ///   <para>ha:ADL</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ADL</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ADL">http://sensormeasurement.appspot.com/ont/home/homeActivity#ADL</seealso>
    let ADL = Prefixed_Name(ha, "ADL") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_date">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_date</seealso>
    let has_have_date = Prefixed_Name(ha, "has_have_date") |> PrefixedName
    /// <summary>
    ///   <para>ha:string</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>string</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#string">http://sensormeasurement.appspot.com/ont/home/homeActivity#string</seealso>
    let string = Prefixed_Name(ha, "string") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Time">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Time</seealso>
    let has_Time = Prefixed_Name(ha, "has_Time") |> PrefixedName
    /// <summary>
    ///   <para>ha:Date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Date</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Date">http://sensormeasurement.appspot.com/ont/home/homeActivity#Date</seealso>
    let Date = Prefixed_Name(ha, "Date") |> PrefixedName
    /// <summary>
    ///   <para>ha:Last_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Last_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Activity</seealso>
    let Last_Activity = Prefixed_Name(ha, "Last_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Collect</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Collect">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Collect</seealso>
    let has_Collect = Prefixed_Name(ha, "has_Collect") |> PrefixedName
    /// <summary>
    ///   <para>ha:Any</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Any</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Any">http://sensormeasurement.appspot.com/ont/home/homeActivity#Any</seealso>
    let Any = Prefixed_Name(ha, "Any") |> PrefixedName
    /// <summary>
    ///   <para>ha:Activity_Log</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Activity_Log</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Activity_Log">http://sensormeasurement.appspot.com/ont/home/homeActivity#Activity_Log</seealso>
    let Activity_Log = Prefixed_Name(ha, "Activity_Log") |> PrefixedName
    /// <summary>
    ///   <para>ha:Alcolhol</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Alcolhol</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Alcolhol">http://sensormeasurement.appspot.com/ont/home/homeActivity#Alcolhol</seealso>
    let Alcolhol = Prefixed_Name(ha, "Alcolhol") |> PrefixedName
    /// <summary>
    ///   <para>ha:Drink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Drink</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Drink">http://sensormeasurement.appspot.com/ont/home/homeActivity#Drink</seealso>
    let Drink = Prefixed_Name(ha, "Drink") |> PrefixedName
    /// <summary>
    ///   <para>ha:Bathroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bathroom</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom</seealso>
    let Bathroom = Prefixed_Name(ha, "Bathroom") |> PrefixedName
    /// <summary>
    ///   <para>ha:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Location</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location">http://sensormeasurement.appspot.com/ont/home/homeActivity#Location</seealso>
    let Location = Prefixed_Name(ha, "Location") |> PrefixedName
    /// <summary>
    ///   <para>ha:Bathroom_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bathroom_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bathroom_Activity</seealso>
    let Bathroom_Activity = Prefixed_Name(ha, "Bathroom_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location</seealso>
    let has_location = Prefixed_Name(ha, "has_location") |> PrefixedName

    /// <summary>
    ///   <para>ha:Location_based_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Location_based_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Location_based_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Location_based_Activity</seealso>
    let Location_based_Activity =
        Prefixed_Name(ha, "Location_based_Activity") |> PrefixedName

    /// <summary>
    ///   <para>ha:Bed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bed</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bed">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bed</seealso>
    let Bed = Prefixed_Name(ha, "Bed") |> PrefixedName
    /// <summary>
    ///   <para>ha:Furniture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Furniture</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Furniture">http://sensormeasurement.appspot.com/ont/home/homeActivity#Furniture</seealso>
    let Furniture = Prefixed_Name(ha, "Furniture") |> PrefixedName
    /// <summary>
    ///   <para>ha:Bedroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bedroom</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom</seealso>
    let Bedroom = Prefixed_Name(ha, "Bedroom") |> PrefixedName
    /// <summary>
    ///   <para>ha:Bedroom_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bedroom_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bedroom_Activity</seealso>
    let Bedroom_Activity = Prefixed_Name(ha, "Bedroom_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:Book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Book</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Book">http://sensormeasurement.appspot.com/ont/home/homeActivity#Book</seealso>
    let Book = Prefixed_Name(ha, "Book") |> PrefixedName
    /// <summary>
    ///   <para>ha:Bottle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Bottle</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Bottle">http://sensormeasurement.appspot.com/ont/home/homeActivity#Bottle</seealso>
    let Bottle = Prefixed_Name(ha, "Bottle") |> PrefixedName
    /// <summary>
    ///   <para>ha:Broom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Broom</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Broom">http://sensormeasurement.appspot.com/ont/home/homeActivity#Broom</seealso>
    let Broom = Prefixed_Name(ha, "Broom") |> PrefixedName
    /// <summary>
    ///   <para>ha:Chair</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Chair</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Chair">http://sensormeasurement.appspot.com/ont/home/homeActivity#Chair</seealso>
    let Chair = Prefixed_Name(ha, "Chair") |> PrefixedName
    /// <summary>
    ///   <para>ha:Coffee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Coffee</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Coffee">http://sensormeasurement.appspot.com/ont/home/homeActivity#Coffee</seealso>
    let Coffee = Prefixed_Name(ha, "Coffee") |> PrefixedName
    /// <summary>
    ///   <para>ha:Computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Computer</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Computer">http://sensormeasurement.appspot.com/ont/home/homeActivity#Computer</seealso>
    let Computer = Prefixed_Name(ha, "Computer") |> PrefixedName
    /// <summary>
    ///   <para>ha:Entertainment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entertainment</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Entertainment">http://sensormeasurement.appspot.com/ont/home/homeActivity#Entertainment</seealso>
    let Entertainment = Prefixed_Name(ha, "Entertainment") |> PrefixedName
    /// <summary>
    ///   <para>ha:Context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Context</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Context">http://sensormeasurement.appspot.com/ont/home/homeActivity#Context</seealso>
    let Context = Prefixed_Name(ha, "Context") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_sensor</seealso>
    let has_have_sensor = Prefixed_Name(ha, "has_have_sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor</seealso>
    let Sensor = Prefixed_Name(ha, "Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Human_Posture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Human_Posture</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human_Posture">http://sensormeasurement.appspot.com/ont/home/homeActivity#Human_Posture</seealso>
    let Human_Posture = Prefixed_Name(ha, "Human_Posture") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_hum_pos</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_hum_pos">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_hum_pos</seealso>
    let has_have_hum_pos = Prefixed_Name(ha, "has_have_hum_pos") |> PrefixedName

    /// <summary>
    ///   <para>ha:has_have_inf_activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_inf_activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_inf_activity</seealso>
    let has_have_inf_activity =
        Prefixed_Name(ha, "has_have_inf_activity") |> PrefixedName

    /// <summary>
    ///   <para>ha:Last_Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Last_Object</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Object">http://sensormeasurement.appspot.com/ont/home/homeActivity#Last_Object</seealso>
    let Last_Object = Prefixed_Name(ha, "Last_Object") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_last_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_object">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_object</seealso>
    let has_have_last_object = Prefixed_Name(ha, "has_have_last_object") |> PrefixedName

    /// <summary>
    ///   <para>ha:has_have_last_activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_last_activity</seealso>
    let has_have_last_activity =
        Prefixed_Name(ha, "has_have_last_activity") |> PrefixedName

    /// <summary>
    ///   <para>ha:integer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>integer</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#integer">http://sensormeasurement.appspot.com/ont/home/homeActivity#integer</seealso>
    let integer = Prefixed_Name(ha, "integer") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Context_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Context_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Context_ID</seealso>
    let has_Context_ID = Prefixed_Name(ha, "has_Context_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_time</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_time">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_time</seealso>
    let has_have_time = Prefixed_Name(ha, "has_have_time") |> PrefixedName
    /// <summary>
    ///   <para>ha:ObjectInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>ObjectInstance</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#ObjectInstance">http://sensormeasurement.appspot.com/ont/home/homeActivity#ObjectInstance</seealso>
    let ObjectInstance = Prefixed_Name(ha, "ObjectInstance") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_obj</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_obj">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_obj</seealso>
    let has_have_obj = Prefixed_Name(ha, "has_have_obj") |> PrefixedName
    /// <summary>
    ///   <para>ha:InferredActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>InferredActivity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#InferredActivity">http://sensormeasurement.appspot.com/ont/home/homeActivity#InferredActivity</seealso>
    let InferredActivity = Prefixed_Name(ha, "InferredActivity") |> PrefixedName
    /// <summary>
    ///   <para>ha:Cooking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cooking</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cooking">http://sensormeasurement.appspot.com/ont/home/homeActivity#Cooking</seealso>
    let Cooking = Prefixed_Name(ha, "Cooking") |> PrefixedName
    /// <summary>
    ///   <para>ha:Electric_Stove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Electric_Stove</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Stove">http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Stove</seealso>
    let Electric_Stove = Prefixed_Name(ha, "Electric_Stove") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_use</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_use">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_use</seealso>
    let has_use = Prefixed_Name(ha, "has_use") |> PrefixedName
    /// <summary>
    ///   <para>ha:Refrigerator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Refrigerator</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Refrigerator">http://sensormeasurement.appspot.com/ont/home/homeActivity#Refrigerator</seealso>
    let Refrigerator = Prefixed_Name(ha, "Refrigerator") |> PrefixedName
    /// <summary>
    ///   <para>ha:Kitchen_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kitchen_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Activity</seealso>
    let Kitchen_Activity = Prefixed_Name(ha, "Kitchen_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:Cupboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Cupboard</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Cupboard">http://sensormeasurement.appspot.com/ont/home/homeActivity#Cupboard</seealso>
    let Cupboard = Prefixed_Name(ha, "Cupboard") |> PrefixedName
    /// <summary>
    ///   <para>ha:Current_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Current_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Current_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Current_Sensor</seealso>
    let Current_Sensor = Prefixed_Name(ha, "Current_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sensor_Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sensor_Type</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor_Type">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sensor_Type</seealso>
    let Sensor_Type = Prefixed_Name(ha, "Sensor_Type") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Year">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Year</seealso>
    let has_Year = Prefixed_Name(ha, "has_Year") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_date">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_date</seealso>
    let has_date = Prefixed_Name(ha, "has_date") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Month</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Month">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Month</seealso>
    let has_Month = Prefixed_Name(ha, "has_Month") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Day_of_week</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Day_of_week">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Day_of_week</seealso>
    let has_Day_of_week = Prefixed_Name(ha, "has_Day_of_week") |> PrefixedName
    /// <summary>
    ///   <para>ha:Door</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Door</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Door">http://sensormeasurement.appspot.com/ont/home/homeActivity#Door</seealso>
    let Door = Prefixed_Name(ha, "Door") |> PrefixedName
    /// <summary>
    ///   <para>ha:Food</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Food</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Food">http://sensormeasurement.appspot.com/ont/home/homeActivity#Food</seealso>
    let Food = Prefixed_Name(ha, "Food") |> PrefixedName
    /// <summary>
    ///   <para>ha:Eating_or_drinking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Eating_or_drinking</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Eating_or_drinking">http://sensormeasurement.appspot.com/ont/home/homeActivity#Eating_or_drinking</seealso>
    let Eating_or_drinking = Prefixed_Name(ha, "Eating_or_drinking") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sit</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sit">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sit</seealso>
    let Sit = Prefixed_Name(ha, "Sit") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_hasPosture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasPosture">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasPosture</seealso>
    let has_hasPosture = Prefixed_Name(ha, "has_hasPosture") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_hasFood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasFood">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasFood</seealso>
    let has_hasFood = Prefixed_Name(ha, "has_hasFood") |> PrefixedName
    /// <summary>
    ///   <para>ha:Electric_Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Electric_Appliance</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Appliance">http://sensormeasurement.appspot.com/ont/home/homeActivity#Electric_Appliance</seealso>
    let Electric_Appliance = Prefixed_Name(ha, "Electric_Appliance") |> PrefixedName
    /// <summary>
    ///   <para>ha:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Object</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object">http://sensormeasurement.appspot.com/ont/home/homeActivity#Object</seealso>
    let Object = Prefixed_Name(ha, "Object") |> PrefixedName
    /// <summary>
    ///   <para>ha:Kitchen_Appliance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kitchen_Appliance</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Appliance">http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen_Appliance</seealso>
    let Kitchen_Appliance = Prefixed_Name(ha, "Kitchen_Appliance") |> PrefixedName
    /// <summary>
    ///   <para>ha:Functional_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Functional_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Functional_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Functional_Activity</seealso>
    let Functional_Activity = Prefixed_Name(ha, "Functional_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_name</seealso>
    let has_name = Prefixed_Name(ha, "has_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_id">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_id</seealso>
    let has_id = Prefixed_Name(ha, "has_id") |> PrefixedName
    /// <summary>
    ///   <para>ha:Gyro_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Gyro_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Gyro_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Gyro_Sensor</seealso>
    let Gyro_Sensor = Prefixed_Name(ha, "Gyro_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Human</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Human</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Human">http://sensormeasurement.appspot.com/ont/home/homeActivity#Human</seealso>
    let Human = Prefixed_Name(ha, "Human") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_act_log</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_act_log">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_act_log</seealso>
    let has_have_act_log = Prefixed_Name(ha, "has_have_act_log") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Posture_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_name</seealso>
    let has_Posture_name = Prefixed_Name(ha, "has_Posture_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Posture_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Posture_ID</seealso>
    let has_Posture_ID = Prefixed_Name(ha, "has_Posture_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Actor">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Actor</seealso>
    let has_Actor = Prefixed_Name(ha, "has_Actor") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_rec_act_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_name</seealso>
    let has_rec_act_name = Prefixed_Name(ha, "has_rec_act_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_rec_act_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_id">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_rec_act_id</seealso>
    let has_rec_act_id = Prefixed_Name(ha, "has_rec_act_id") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Have_activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Have_activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Have_activity</seealso>
    let has_Have_activity = Prefixed_Name(ha, "has_Have_activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:Infrared_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Infrared_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Infrared_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Infrared_Sensor</seealso>
    let Infrared_Sensor = Prefixed_Name(ha, "Infrared_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Juice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Juice</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Juice">http://sensormeasurement.appspot.com/ont/home/homeActivity#Juice</seealso>
    let Juice = Prefixed_Name(ha, "Juice") |> PrefixedName
    /// <summary>
    ///   <para>ha:Kettle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kettle</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kettle">http://sensormeasurement.appspot.com/ont/home/homeActivity#Kettle</seealso>
    let Kettle = Prefixed_Name(ha, "Kettle") |> PrefixedName
    /// <summary>
    ///   <para>ha:Kitchen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Kitchen</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen">http://sensormeasurement.appspot.com/ont/home/homeActivity#Kitchen</seealso>
    let Kitchen = Prefixed_Name(ha, "Kitchen") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_have_activities</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_activities">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_have_activities</seealso>
    let has_have_activities = Prefixed_Name(ha, "has_have_activities") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Activity_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_ID</seealso>
    let has_Activity_ID = Prefixed_Name(ha, "has_Activity_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_location_concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location_concept">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_location_concept</seealso>
    let has_location_concept = Prefixed_Name(ha, "has_location_concept") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Activity_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Activity_name</seealso>
    let has_Activity_name = Prefixed_Name(ha, "has_Activity_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Object_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_name</seealso>
    let has_Object_name = Prefixed_Name(ha, "has_Object_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Object_info</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_info">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_info</seealso>
    let has_Object_info = Prefixed_Name(ha, "has_Object_info") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Object_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Object_ID</seealso>
    let has_Object_ID = Prefixed_Name(ha, "has_Object_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:Lavatory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lavatory</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lavatory">http://sensormeasurement.appspot.com/ont/home/homeActivity#Lavatory</seealso>
    let Lavatory = Prefixed_Name(ha, "Lavatory") |> PrefixedName
    /// <summary>
    ///   <para>ha:Lie-down</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lie-down</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lie-down">http://sensormeasurement.appspot.com/ont/home/homeActivity#Lie-down</seealso>
    let Lie_down = Prefixed_Name(ha, "Lie-down") |> PrefixedName
    /// <summary>
    ///   <para>ha:Living_room_Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Living_room_Activity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Living_room_Activity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Living_room_Activity</seealso>
    let Living_room_Activity = Prefixed_Name(ha, "Living_room_Activity") |> PrefixedName
    /// <summary>
    ///   <para>ha:Livingroom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Livingroom</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Livingroom">http://sensormeasurement.appspot.com/ont/home/homeActivity#Livingroom</seealso>
    let Livingroom = Prefixed_Name(ha, "Livingroom") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Location_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_name">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_name</seealso>
    let has_Location_name = Prefixed_Name(ha, "has_Location_name") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Location_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Location_ID</seealso>
    let has_Location_ID = Prefixed_Name(ha, "has_Location_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:Object_based_Actvity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Object_based_Actvity</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Object_based_Actvity">http://sensormeasurement.appspot.com/ont/home/homeActivity#Object_based_Actvity</seealso>
    let Object_based_Actvity = Prefixed_Name(ha, "Object_based_Actvity") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Combine_with</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Combine_with">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Combine_with</seealso>
    let has_Combine_with = Prefixed_Name(ha, "has_Combine_with") |> PrefixedName

    /// <summary>
    ///   <para>ha:Lying_down___relaxing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Lying_down___relaxing</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Lying_down___relaxing">http://sensormeasurement.appspot.com/ont/home/homeActivity#Lying_down___relaxing</seealso>
    let Lying_down___relaxing =
        Prefixed_Name(ha, "Lying_down___relaxing") |> PrefixedName

    /// <summary>
    ///   <para>ha:Sofa</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sofa</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sofa">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sofa</seealso>
    let Sofa = Prefixed_Name(ha, "Sofa") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_posture</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_posture">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_posture</seealso>
    let has_posture = Prefixed_Name(ha, "has_posture") |> PrefixedName
    /// <summary>
    ///   <para>ha:Magnetic_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Magnetic_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Magnetic_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Magnetic_Sensor</seealso>
    let Magnetic_Sensor = Prefixed_Name(ha, "Magnetic_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Making_a_coffee</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Making_a_coffee</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Making_a_coffee">http://sensormeasurement.appspot.com/ont/home/homeActivity#Making_a_coffee</seealso>
    let Making_a_coffee = Prefixed_Name(ha, "Making_a_coffee") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_hasDrinkType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasDrinkType">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_hasDrinkType</seealso>
    let has_hasDrinkType = Prefixed_Name(ha, "has_hasDrinkType") |> PrefixedName
    /// <summary>
    ///   <para>ha:Microwave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Microwave</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Microwave">http://sensormeasurement.appspot.com/ont/home/homeActivity#Microwave</seealso>
    let Microwave = Prefixed_Name(ha, "Microwave") |> PrefixedName
    /// <summary>
    ///   <para>ha:Milk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Milk</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Milk">http://sensormeasurement.appspot.com/ont/home/homeActivity#Milk</seealso>
    let Milk = Prefixed_Name(ha, "Milk") |> PrefixedName
    /// <summary>
    ///   <para>ha:Mop</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mop</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Mop">http://sensormeasurement.appspot.com/ont/home/homeActivity#Mop</seealso>
    let Mop = Prefixed_Name(ha, "Mop") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_isAttached</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_isAttached">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_isAttached</seealso>
    let has_isAttached = Prefixed_Name(ha, "has_isAttached") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Current_location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Current_location">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Current_location</seealso>
    let has_Current_location = Prefixed_Name(ha, "has_Current_location") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_obj_inst_id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_obj_inst_id">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_obj_inst_id</seealso>
    let has_obj_inst_id = Prefixed_Name(ha, "has_obj_inst_id") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_object">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_object</seealso>
    let has_object = Prefixed_Name(ha, "has_object") |> PrefixedName
    /// <summary>
    ///   <para>ha:Oven</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Oven</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Oven">http://sensormeasurement.appspot.com/ont/home/homeActivity#Oven</seealso>
    let Oven = Prefixed_Name(ha, "Oven") |> PrefixedName
    /// <summary>
    ///   <para>ha:Phone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Phone</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Phone">http://sensormeasurement.appspot.com/ont/home/homeActivity#Phone</seealso>
    let Phone = Prefixed_Name(ha, "Phone") |> PrefixedName
    /// <summary>
    ///   <para>ha:Pressure_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Pressure_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Pressure_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Pressure_Sensor</seealso>
    let Pressure_Sensor = Prefixed_Name(ha, "Pressure_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Reading_a_book</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Reading_a_book</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Reading_a_book">http://sensormeasurement.appspot.com/ont/home/homeActivity#Reading_a_book</seealso>
    let Reading_a_book = Prefixed_Name(ha, "Reading_a_book") |> PrefixedName
    /// <summary>
    ///   <para>ha:RelationalConcept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>RelationalConcept</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#RelationalConcept">http://sensormeasurement.appspot.com/ont/home/homeActivity#RelationalConcept</seealso>
    let RelationalConcept = Prefixed_Name(ha, "RelationalConcept") |> PrefixedName
    /// <summary>
    ///   <para>ha:Scrubbing_the_floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Scrubbing_the_floor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Scrubbing_the_floor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Scrubbing_the_floor</seealso>
    let Scrubbing_the_floor = Prefixed_Name(ha, "Scrubbing_the_floor") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Sensor_ID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Sensor_ID">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Sensor_ID</seealso>
    let has_Sensor_ID = Prefixed_Name(ha, "has_Sensor_ID") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_AttachTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_AttachTo">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_AttachTo</seealso>
    let has_AttachTo = Prefixed_Name(ha, "has_AttachTo") |> PrefixedName
    /// <summary>
    ///   <para>ha:has_Status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Status">http://sensormeasurement.appspot.com/ont/home/homeActivity#has_Status</seealso>
    let has_Status = Prefixed_Name(ha, "has_Status") |> PrefixedName
    /// <summary>
    ///   <para>ha:Shower</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Shower</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Shower">http://sensormeasurement.appspot.com/ont/home/homeActivity#Shower</seealso>
    let Shower = Prefixed_Name(ha, "Shower") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sink</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sink">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sink</seealso>
    let Sink = Prefixed_Name(ha, "Sink") |> PrefixedName

    /// <summary>
    ///   <para>ha:Sitting_on_the_toilet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sitting_on_the_toilet</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sitting_on_the_toilet">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sitting_on_the_toilet</seealso>
    let Sitting_on_the_toilet =
        Prefixed_Name(ha, "Sitting_on_the_toilet") |> PrefixedName

    /// <summary>
    ///   <para>ha:Sleeping</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sleeping</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sleeping">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sleeping</seealso>
    let Sleeping = Prefixed_Name(ha, "Sleeping") |> PrefixedName
    /// <summary>
    ///   <para>ha:Softdrink</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Softdrink</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Softdrink">http://sensormeasurement.appspot.com/ont/home/homeActivity#Softdrink</seealso>
    let Softdrink = Prefixed_Name(ha, "Softdrink") |> PrefixedName
    /// <summary>
    ///   <para>ha:Stand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stand</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stand">http://sensormeasurement.appspot.com/ont/home/homeActivity#Stand</seealso>
    let Stand = Prefixed_Name(ha, "Stand") |> PrefixedName
    /// <summary>
    ///   <para>ha:Stereo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Stereo</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Stereo">http://sensormeasurement.appspot.com/ont/home/homeActivity#Stereo</seealso>
    let Stereo = Prefixed_Name(ha, "Stereo") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sugar</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sugar</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sugar">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sugar</seealso>
    let Sugar = Prefixed_Name(ha, "Sugar") |> PrefixedName
    /// <summary>
    ///   <para>ha:Sweeping_the_floor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Sweeping_the_floor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Sweeping_the_floor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Sweeping_the_floor</seealso>
    let Sweeping_the_floor = Prefixed_Name(ha, "Sweeping_the_floor") |> PrefixedName
    /// <summary>
    ///   <para>ha:TV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>TV</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#TV">http://sensormeasurement.appspot.com/ont/home/homeActivity#TV</seealso>
    let TV = Prefixed_Name(ha, "TV") |> PrefixedName
    /// <summary>
    ///   <para>ha:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Table</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Table">http://sensormeasurement.appspot.com/ont/home/homeActivity#Table</seealso>
    let Table = Prefixed_Name(ha, "Table") |> PrefixedName
    /// <summary>
    ///   <para>ha:Taking_a_bath</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Taking_a_bath</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Taking_a_bath">http://sensormeasurement.appspot.com/ont/home/homeActivity#Taking_a_bath</seealso>
    let Taking_a_bath = Prefixed_Name(ha, "Taking_a_bath") |> PrefixedName
    /// <summary>
    ///   <para>ha:Tea</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Tea</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Tea">http://sensormeasurement.appspot.com/ont/home/homeActivity#Tea</seealso>
    let Tea = Prefixed_Name(ha, "Tea") |> PrefixedName
    /// <summary>
    ///   <para>ha:Ultrasonic_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Ultrasonic_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Ultrasonic_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Ultrasonic_Sensor</seealso>
    let Ultrasonic_Sensor = Prefixed_Name(ha, "Ultrasonic_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:UndefinedClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>UndefinedClass</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#UndefinedClass">http://sensormeasurement.appspot.com/ont/home/homeActivity#UndefinedClass</seealso>
    let UndefinedClass = Prefixed_Name(ha, "UndefinedClass") |> PrefixedName
    /// <summary>
    ///   <para>ha:Wash_dishes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Wash_dishes</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Wash_dishes">http://sensormeasurement.appspot.com/ont/home/homeActivity#Wash_dishes</seealso>
    let Wash_dishes = Prefixed_Name(ha, "Wash_dishes") |> PrefixedName
    /// <summary>
    ///   <para>ha:Watching_TV</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Watching_TV</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Watching_TV">http://sensormeasurement.appspot.com/ont/home/homeActivity#Watching_TV</seealso>
    let Watching_TV = Prefixed_Name(ha, "Watching_TV") |> PrefixedName
    /// <summary>
    ///   <para>ha:Water_Meter_Sensor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Water_Meter_Sensor</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Water_Meter_Sensor">http://sensormeasurement.appspot.com/ont/home/homeActivity#Water_Meter_Sensor</seealso>
    let Water_Meter_Sensor = Prefixed_Name(ha, "Water_Meter_Sensor") |> PrefixedName
    /// <summary>
    ///   <para>ha:Working_on_computer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Working_on_computer</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#Working_on_computer">http://sensormeasurement.appspot.com/ont/home/homeActivity#Working_on_computer</seealso>
    let Working_on_computer = Prefixed_Name(ha, "Working_on_computer") |> PrefixedName
    /// <summary>
    ///   <para>ha:hasAttribute</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasAttribute</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasAttribute">http://sensormeasurement.appspot.com/ont/home/homeActivity#hasAttribute</seealso>
    let hasAttribute = Prefixed_Name(ha, "hasAttribute") |> PrefixedName
    /// <summary>
    ///   <para>ha:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>hasPart</para></remarks>
    /// <seealso href="http://sensormeasurement.appspot.com/ont/home/homeActivity#hasPart">http://sensormeasurement.appspot.com/ont/home/homeActivity#hasPart</seealso>
    let hasPart = Prefixed_Name(ha, "hasPart") |> PrefixedName
