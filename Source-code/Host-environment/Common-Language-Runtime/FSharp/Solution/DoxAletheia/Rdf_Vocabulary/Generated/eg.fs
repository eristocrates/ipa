namespace http.www.example.org.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module eg =
    let _namespace_iri = Namespace_Iri eg |> NamespaceIRI

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#ARM9</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:CPU</para>
    ///   <para>"The ARM ARM9 central processing unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#ARM9">http://www.example.org/2007/uwa/context/examples.owl#ARM9</seealso>
    let ``_2007/uwa/context/examples.owl#ARM9`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#ARM9") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Battery_Hyp_Devi</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Battery</para>
    ///   <para>"The battery in a Hypothetical Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Battery_Hyp_Devi">http://www.example.org/2007/uwa/context/examples.owl#Battery_Hyp_Devi</seealso>
    let ``_2007/uwa/context/examples.owl#Battery_Hyp_Devi`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Battery_Hyp_Devi") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Camera_Hypothetical_Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Camera</para>
    ///   <para>"This represents the camera on a Hypothetical Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Camera_Hypothetical_Device">http://www.example.org/2007/uwa/context/examples.owl#Camera_Hypothetical_Device</seealso>
    let ``_2007/uwa/context/examples.owl#Camera_Hypothetical_Device`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Camera_Hypothetical_Device") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#DeviceHardware_Hypothetical_Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:DeviceHardware</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#DeviceHardware_Hypothetical_Device">http://www.example.org/2007/uwa/context/examples.owl#DeviceHardware_Hypothetical_Device</seealso>
    let ``_2007/uwa/context/examples.owl#DeviceHardware_Hypothetical_Device`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#DeviceHardware_Hypothetical_Device") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#DeviceSoftware_Hyp_Devi</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:DeviceSoftware</para>
    ///   <para>"Device Software Example"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#DeviceSoftware_Hyp_Devi">http://www.example.org/2007/uwa/context/examples.owl#DeviceSoftware_Hyp_Devi</seealso>
    let ``_2007/uwa/context/examples.owl#DeviceSoftware_Hyp_Devi`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#DeviceSoftware_Hyp_Devi") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Device_Hypothetical</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcn:Device</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Device_Hypothetical">http://www.example.org/2007/uwa/context/examples.owl#Device_Hypothetical</seealso>
    let ``_2007/uwa/context/examples.owl#Device_Hypothetical`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Device_Hypothetical") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Display_Hypothetical_Device</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Display</para>
    ///   <para>"The display for the Hypothetical device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Display_Hypothetical_Device">http://www.example.org/2007/uwa/context/examples.owl#Display_Hypothetical_Device</seealso>
    let ``_2007/uwa/context/examples.owl#Display_Hypothetical_Device`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Display_Hypothetical_Device") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Environment_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcn:Environment</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Environment_2">http://www.example.org/2007/uwa/context/examples.owl#Environment_2</seealso>
    let ``_2007/uwa/context/examples.owl#Environment_2`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Environment_2") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#ExampleDC_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>dcn:DeliveryContext</para>
    ///   <para>"Example of a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#ExampleDC_1">http://www.example.org/2007/uwa/context/examples.owl#ExampleDC_1</seealso>
    let ``_2007/uwa/context/examples.owl#ExampleDC_1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#ExampleDC_1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_11</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_11">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_11</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_11`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_11") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_12</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_12">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_12</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_12`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_12") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_13</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_13">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_13</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_13`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_13") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_14</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_14">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_14</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_14`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_14") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_15</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_15">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_15</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_15`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_15") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_16</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_16">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_16</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_16`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_16") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_17</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_17">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_17</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_17`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_17") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_4</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_4">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_4</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_4`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_4") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_8</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_8">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_8</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_8`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_8") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#FeatureRestriction_9</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:FeatureRestriction</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_9">http://www.example.org/2007/uwa/context/examples.owl#FeatureRestriction_9</seealso>
    let ``_2007/uwa/context/examples.owl#FeatureRestriction_9`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#FeatureRestriction_9") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#J2meRuntimeEnvironment_20</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meRuntimeEnvironment</para>
    ///   <para>"KVM"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#J2meRuntimeEnvironment_20">http://www.example.org/2007/uwa/context/examples.owl#J2meRuntimeEnvironment_20</seealso>
    let ``_2007/uwa/context/examples.owl#J2meRuntimeEnvironment_20`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#J2meRuntimeEnvironment_20") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#J2meRuntimeEnvironment_27</para>
    /// </summary>
    /// <remarks>
    ///   <para>java:J2meRuntimeEnvironment</para>
    ///   <para>"J9"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#J2meRuntimeEnvironment_27">http://www.example.org/2007/uwa/context/examples.owl#J2meRuntimeEnvironment_27</seealso>
    let ``_2007/uwa/context/examples.owl#J2meRuntimeEnvironment_27`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#J2meRuntimeEnvironment_27") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#JtwiRuntimeEnvironment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a JTWI-compliant J2ME runtime environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"JTWI Runtime Environment"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#JtwiRuntimeEnvironment">http://www.example.org/2007/uwa/context/examples.owl#JtwiRuntimeEnvironment</seealso>
    let ``_2007/uwa/context/examples.owl#JtwiRuntimeEnvironment`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#JtwiRuntimeEnvironment") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#LocationProvider_ExampleGPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.w3.org/2007/uwa/context/location.owl#LocationProvider&gt;</para>
    ///   <para>"A location provider based on a GPS receiver"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#LocationProvider_ExampleGPS">http://www.example.org/2007/uwa/context/examples.owl#LocationProvider_ExampleGPS</seealso>
    let ``_2007/uwa/context/examples.owl#LocationProvider_ExampleGPS`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#LocationProvider_ExampleGPS") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Card</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:MemoryUnit</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Card">http://www.example.org/2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Card</seealso>
    let ``_2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Card`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Card") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Internal</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:MemoryUnit</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Internal">http://www.example.org/2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Internal</seealso>
    let ``_2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Internal`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#MemoryUnit_Hyp_Dev_Internal") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#MmsClient_Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>push:MmsClient</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#MmsClient_Example">http://www.example.org/2007/uwa/context/examples.owl#MmsClient_Example</seealso>
    let ``_2007/uwa/context/examples.owl#MmsClient_Example`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#MmsClient_Example") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#MobileNetwork_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:Network</para>
    ///   <para>"Example Mobile Network"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#MobileNetwork_1">http://www.example.org/2007/uwa/context/examples.owl#MobileNetwork_1</seealso>
    let ``_2007/uwa/context/examples.owl#MobileNetwork_1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#MobileNetwork_1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#NetworkBearer_2</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkBearer</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#NetworkBearer_2">http://www.example.org/2007/uwa/context/examples.owl#NetworkBearer_2</seealso>
    let ``_2007/uwa/context/examples.owl#NetworkBearer_2`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#NetworkBearer_2") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#NetworkProfile_7</para>
    /// </summary>
    /// <remarks>
    ///   <para>net:NetworkSupport</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#NetworkProfile_7">http://www.example.org/2007/uwa/context/examples.owl#NetworkProfile_7</seealso>
    let ``_2007/uwa/context/examples.owl#NetworkProfile_7`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#NetworkProfile_7") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Nokia</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Vendor</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Nokia">http://www.example.org/2007/uwa/context/examples.owl#Nokia</seealso>
    let ``_2007/uwa/context/examples.owl#Nokia`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Nokia") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#OperatingSystem_SymbianOS7</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:OperatingSystem</para>
    ///   <para>"Example Operating System"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#OperatingSystem_SymbianOS7">http://www.example.org/2007/uwa/context/examples.owl#OperatingSystem_SymbianOS7</seealso>
    let ``_2007/uwa/context/examples.owl#OperatingSystem_SymbianOS7`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#OperatingSystem_SymbianOS7") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Place_Example</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.w3.org/2007/uwa/context/location.owl#Location&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Place_Example">http://www.example.org/2007/uwa/context/examples.owl#Place_Example</seealso>
    let ``_2007/uwa/context/examples.owl#Place_Example`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Place_Example") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#Position1</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.w3.org/2007/uwa/context/location.owl#Position&gt;</para>
    ///   <para>"An example position"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#Position1">http://www.example.org/2007/uwa/context/examples.owl#Position1</seealso>
    let ``_2007/uwa/context/examples.owl#Position1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#Position1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#TimesFont10</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:Font</para>
    ///   <para>"Example instances with a Times Roman 10 font"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#TimesFont10">http://www.example.org/2007/uwa/context/examples.owl#TimesFont10</seealso>
    let ``_2007/uwa/context/examples.owl#TimesFont10`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#TimesFont10") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#TimesNewRoman</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:FontFamily</para>
    ///   <para>"Example Font Family 'Times New Roman'"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Times New Roman"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#TimesNewRoman">http://www.example.org/2007/uwa/context/examples.owl#TimesNewRoman</seealso>
    let ``_2007/uwa/context/examples.owl#TimesNewRoman`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#TimesNewRoman") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#UTMCoordinates_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.w3.org/2007/uwa/context/location.owl#UTMCoordinates&gt;</para>
    ///   <para>"Example UTM Coordinates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#UTMCoordinates_1">http://www.example.org/2007/uwa/context/examples.owl#UTMCoordinates_1</seealso>
    let ``_2007/uwa/context/examples.owl#UTMCoordinates_1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#UTMCoordinates_1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#VideoPlayer_Real1</para>
    /// </summary>
    /// <remarks>
    ///   <para>soft:VideoPlayer</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#VideoPlayer_Real1">http://www.example.org/2007/uwa/context/examples.owl#VideoPlayer_Real1</seealso>
    let ``_2007/uwa/context/examples.owl#VideoPlayer_Real1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#VideoPlayer_Real1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WGS84Coordinates_25</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://www.w3.org/2007/uwa/context/location.owl#WGS84Coordinates&gt;</para>
    ///   <para>"Example WGS84 coordinates"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WGS84Coordinates_25">http://www.example.org/2007/uwa/context/examples.owl#WGS84Coordinates_25</seealso>
    let ``_2007/uwa/context/examples.owl#WGS84Coordinates_25`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WGS84Coordinates_25") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WapPushClient_5</para>
    /// </summary>
    /// <remarks>
    ///   <para>push:WapPushClient</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WapPushClient_5">http://www.example.org/2007/uwa/context/examples.owl#WapPushClient_5</seealso>
    let ``_2007/uwa/context/examples.owl#WapPushClient_5`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WapPushClient_5") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WapPushClient_Example_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>push:WapPushClient</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WapPushClient_Example_1">http://www.example.org/2007/uwa/context/examples.owl#WapPushClient_Example_1</seealso>
    let ``_2007/uwa/context/examples.owl#WapPushClient_Example_1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WapPushClient_Example_1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WebBrowserFeatures_1</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowserFeatures</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WebBrowserFeatures_1">http://www.example.org/2007/uwa/context/examples.owl#WebBrowserFeatures_1</seealso>
    let ``_2007/uwa/context/examples.owl#WebBrowserFeatures_1`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WebBrowserFeatures_1") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WebBrowser_x</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowser</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WebBrowser_x">http://www.example.org/2007/uwa/context/examples.owl#WebBrowser_x</seealso>
    let ``_2007/uwa/context/examples.owl#WebBrowser_x`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WebBrowser_x") |> PrefixedName

    /// <summary>
    ///   <para>eg:2007/uwa/context/examples.owl#WebBrowser_y</para>
    /// </summary>
    /// <remarks>
    ///   <para>web:WebBrowser</para>
    /// </remarks>
    /// <seealso href="http://www.example.org/2007/uwa/context/examples.owl#WebBrowser_y">http://www.example.org/2007/uwa/context/examples.owl#WebBrowser_y</seealso>
    let ``_2007/uwa/context/examples.owl#WebBrowser_y`` =
        Prefixed_Name(eg, "2007/uwa/context/examples.owl#WebBrowser_y") |> PrefixedName
