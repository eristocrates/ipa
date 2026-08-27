namespace http.www.w3.org._2007.uwa.context.hardware.owl.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module hard =
    let _namespace_iri = Namespace_Iri hard |> NamespaceIRI
    /// <summary>
    ///   <para>hard:Battery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a battery in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Battery">http://www.w3.org/2007/uwa/context/hardware.owl#Battery</seealso>
    let Battery = Prefixed_Name(hard, "Battery") |> PrefixedName
    /// <summary>
    ///   <para>hard:BluetoothHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents device hardware that can be used to access to Bluetooth technology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothHardware">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothHardware</seealso>
    let BluetoothHardware = Prefixed_Name(hard, "BluetoothHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:BluetoothProfile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes a specific Bluetooth profile used to support a particular user scenario"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Profile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile</seealso>
    let BluetoothProfile = Prefixed_Name(hard, "BluetoothProfile") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_dialup</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how devices provide modem services."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_dialup">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_dialup</seealso>
    let BluetoothProfile_dialup =
        Prefixed_Name(hard, "BluetoothProfile_dialup") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_fileTransfer</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how devices perform file transfer."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_fileTransfer">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_fileTransfer</seealso>
    let BluetoothProfile_fileTransfer =
        Prefixed_Name(hard, "BluetoothProfile_fileTransfer") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_genericAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines the basic level of function that all devices must implement."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_genericAccess">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_genericAccess</seealso>
    let BluetoothProfile_genericAccess =
        Prefixed_Name(hard, "BluetoothProfile_genericAccess") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_genericObjExch</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how the Infra Red Data Association's OBEX object exchange protocol is used to allow devices to exchange objects."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_genericObjExch">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_genericObjExch</seealso>
    let BluetoothProfile_genericObjExch =
        Prefixed_Name(hard, "BluetoothProfile_genericObjExch") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_headSet</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how headsets communicate with devices."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_headSet">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_headSet</seealso>
    let BluetoothProfile_headSet =
        Prefixed_Name(hard, "BluetoothProfile_headSet") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_objectPush</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how predefined standard objects, such as virtual business cards, are pushed to another device."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_objectPush">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_objectPush</seealso>
    let BluetoothProfile_objectPush =
        Prefixed_Name(hard, "BluetoothProfile_objectPush") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothProfile_serialPort</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothProfile</para>
    ///   <para>"The Bluetooth profile that defines how devices provide serial port emulation for communication."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_serialPort">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothProfile_serialPort</seealso>
    let BluetoothProfile_serialPort =
        Prefixed_Name(hard, "BluetoothProfile_serialPort") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the possible statuses of Bluetooth in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus</seealso>
    let BluetoothStatus = Prefixed_Name(hard, "BluetoothStatus") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothStatus_DISCOVERABLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothStatus</para>
    ///   <para>"This status indicates that the device can be discovered by other Bluetooth devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Discoverable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_DISCOVERABLE">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_DISCOVERABLE</seealso>
    let BluetoothStatus_DISCOVERABLE =
        Prefixed_Name(hard, "BluetoothStatus_DISCOVERABLE") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothStatus_HIDDEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothStatus</para>
    ///   <para>"This status indicates that the device cannot be discovered by other Bluetooth devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Status Hidden"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_HIDDEN">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_HIDDEN</seealso>
    let BluetoothStatus_HIDDEN =
        Prefixed_Name(hard, "BluetoothStatus_HIDDEN") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothStatus_PAIRED</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothStatus</para>
    ///   <para>"This status indicates that the device is paired to other Bluetooth device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Status Paired"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_PAIRED">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_PAIRED</seealso>
    let BluetoothStatus_PAIRED =
        Prefixed_Name(hard, "BluetoothStatus_PAIRED") |> PrefixedName

    /// <summary>
    ///   <para>hard:BluetoothStatus_TEMP_DISCOVERABLE</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:BluetoothStatus</para>
    ///   <para>"This status indicates that the device can be temporarily discovered by other Bluetooth devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Status Temporarily Discoverable"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_TEMP_DISCOVERABLE">http://www.w3.org/2007/uwa/context/hardware.owl#BluetoothStatus_TEMP_DISCOVERABLE</seealso>
    let BluetoothStatus_TEMP_DISCOVERABLE =
        Prefixed_Name(hard, "BluetoothStatus_TEMP_DISCOVERABLE") |> PrefixedName

    /// <summary>
    ///   <para>hard:CPU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes a central processing unit associated with a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CPU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#CPU">http://www.w3.org/2007/uwa/context/hardware.owl#CPU</seealso>
    let CPU = Prefixed_Name(hard, "CPU") |> PrefixedName
    /// <summary>
    ///   <para>hard:Camera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a camera in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Camera"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Camera">http://www.w3.org/2007/uwa/context/hardware.owl#Camera</seealso>
    let Camera = Prefixed_Name(hard, "Camera") |> PrefixedName
    /// <summary>
    ///   <para>hard:CellularHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents device hardware that can be used to access to mobile operator telephony networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Cellular Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#CellularHardware">http://www.w3.org/2007/uwa/context/hardware.owl#CellularHardware</seealso>
    let CellularHardware = Prefixed_Name(hard, "CellularHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:CharacterDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a character oriented display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#CharacterDisplay">http://www.w3.org/2007/uwa/context/hardware.owl#CharacterDisplay</seealso>
    let CharacterDisplay = Prefixed_Name(hard, "CharacterDisplay") |> PrefixedName

    /// <summary>
    ///   <para>hard:Context_HardwareEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the base class for those ontology entities that have to do with hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Context Hardware Entity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Context_HardwareEntity">http://www.w3.org/2007/uwa/context/hardware.owl#Context_HardwareEntity</seealso>
    let Context_HardwareEntity =
        Prefixed_Name(hard, "Context_HardwareEntity") |> PrefixedName

    /// <summary>
    ///   <para>hard:DeviceHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the hardware in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#DeviceHardware">http://www.w3.org/2007/uwa/context/hardware.owl#DeviceHardware</seealso>
    let DeviceHardware = Prefixed_Name(hard, "DeviceHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:Display</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a visual display on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Display">http://www.w3.org/2007/uwa/context/hardware.owl#Display</seealso>
    let Display = Prefixed_Name(hard, "Display") |> PrefixedName

    /// <summary>
    ///   <para>hard:Feature_COLOR_DISPLAY</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Feature</para>
    ///   <para>"This feature indicates that color display is supported"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Color Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Feature_COLOR_DISPLAY">http://www.w3.org/2007/uwa/context/hardware.owl#Feature_COLOR_DISPLAY</seealso>
    let Feature_COLOR_DISPLAY =
        Prefixed_Name(hard, "Feature_COLOR_DISPLAY") |> PrefixedName

    /// <summary>
    ///   <para>hard:Feature_MONOCHROME_DISPLAY</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:Feature</para>
    ///   <para>"This feature indicates that a display is monochrome"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MonochromeDisplay"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Feature_MONOCHROME_DISPLAY">http://www.w3.org/2007/uwa/context/hardware.owl#Feature_MONOCHROME_DISPLAY</seealso>
    let Feature_MONOCHROME_DISPLAY =
        Prefixed_Name(hard, "Feature_MONOCHROME_DISPLAY") |> PrefixedName

    /// <summary>
    ///   <para>hard:GraphicDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a graphic display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Graphic Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#GraphicDisplay">http://www.w3.org/2007/uwa/context/hardware.owl#GraphicDisplay</seealso>
    let GraphicDisplay = Prefixed_Name(hard, "GraphicDisplay") |> PrefixedName
    /// <summary>
    ///   <para>hard:HardwareComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a hardware component of a Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hardware Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#HardwareComponent">http://www.w3.org/2007/uwa/context/hardware.owl#HardwareComponent</seealso>
    let HardwareComponent = Prefixed_Name(hard, "HardwareComponent") |> PrefixedName
    /// <summary>
    ///   <para>hard:HardwareStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the status of a hardware component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hardware Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus">http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus</seealso>
    let HardwareStatus = Prefixed_Name(hard, "HardwareStatus") |> PrefixedName
    /// <summary>
    ///   <para>hard:HardwareStatus_OFF</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:HardwareStatus</para>
    ///   <para>"This status indicates that the hardware component is off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Off"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_OFF">http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_OFF</seealso>
    let HardwareStatus_OFF = Prefixed_Name(hard, "HardwareStatus_OFF") |> PrefixedName
    /// <summary>
    ///   <para>hard:HardwareStatus_ON</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:HardwareStatus</para>
    ///   <para>"This status indicates that the hardware component is on"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"On"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_ON">http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_ON</seealso>
    let HardwareStatus_ON = Prefixed_Name(hard, "HardwareStatus_ON") |> PrefixedName

    /// <summary>
    ///   <para>hard:HardwareStatus_STANDBY</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:HardwareStatus</para>
    ///   <para>"This status indicates that harware component is in standby mode"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_STANDBY">http://www.w3.org/2007/uwa/context/hardware.owl#HardwareStatus_STANDBY</seealso>
    let HardwareStatus_STANDBY =
        Prefixed_Name(hard, "HardwareStatus_STANDBY") |> PrefixedName

    /// <summary>
    ///   <para>hard:InfraredHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the infrared hardware on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"InfraredHardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InfraredHardware">http://www.w3.org/2007/uwa/context/hardware.owl#InfraredHardware</seealso>
    let InfraredHardware = Prefixed_Name(hard, "InfraredHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:InputDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an input mechanism that can be available in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice</seealso>
    let InputDevice = Prefixed_Name(hard, "InputDevice") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_CLICK_WHEEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"A wheel that is normally placed either below the screen or on the side of the device that lets the user quickly move up and down and click on link or items on the screen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Click Wheel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_CLICK_WHEEL">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_CLICK_WHEEL</seealso>
    let InputDevice_CLICK_WHEEL =
        Prefixed_Name(hard, "InputDevice_CLICK_WHEEL") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_FOUR_WAY_SCROLLER</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"Scroll up and down and side to side"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Four Way Scroller"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_FOUR_WAY_SCROLLER">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_FOUR_WAY_SCROLLER</seealso>
    let InputDevice_FOUR_WAY_SCROLLER =
        Prefixed_Name(hard, "InputDevice_FOUR_WAY_SCROLLER") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_JOG_DIAL</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"A jog dial, jog wheel, shuttle dial, or shuttle wheel is a type of knob, ring, wheel, or dial which allows the user to shuttle or jog"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Jog Dial"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_JOG_DIAL">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_JOG_DIAL</seealso>
    let InputDevice_JOG_DIAL =
        Prefixed_Name(hard, "InputDevice_JOG_DIAL") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_MOUSE</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"Represents a typical two button mouse found on a PC device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Mouse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_MOUSE">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_MOUSE</seealso>
    let InputDevice_MOUSE = Prefixed_Name(hard, "InputDevice_MOUSE") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_NUMERIC_KEYPAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Keyboard</para>
    ///   <para>"A keyboard with only numeric input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Numeric Keypad"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_NUMERIC_KEYPAD">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_NUMERIC_KEYPAD</seealso>
    let InputDevice_NUMERIC_KEYPAD =
        Prefixed_Name(hard, "InputDevice_NUMERIC_KEYPAD") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_PHONE_KEYPAD</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Keyboard</para>
    ///   <para>"A phone-style keypad where multiple symbols are available through multiple presses of a limited number of keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Phone Keypad"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_PHONE_KEYPAD">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_PHONE_KEYPAD</seealso>
    let InputDevice_PHONE_KEYPAD =
        Prefixed_Name(hard, "InputDevice_PHONE_KEYPAD") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_QWERTY_KEYBOARD</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:Keyboard</para>
    ///   <para>"Represents a full alphanumeric keyboard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Qwerty Keyboard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_QWERTY_KEYBOARD">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_QWERTY_KEYBOARD</seealso>
    let InputDevice_QWERTY_KEYBOARD =
        Prefixed_Name(hard, "InputDevice_QWERTY_KEYBOARD") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_STYLUS</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"Represents a stylus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Stylus"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_STYLUS">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_STYLUS</seealso>
    let InputDevice_STYLUS = Prefixed_Name(hard, "InputDevice_STYLUS") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_TOUCH_SCREEN</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:TactileDisplay</para>
    ///   <para>"Touch screen that allows pointing to an area on the screen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Touch Screen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_TOUCH_SCREEN">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_TOUCH_SCREEN</seealso>
    let InputDevice_TOUCH_SCREEN =
        Prefixed_Name(hard, "InputDevice_TOUCH_SCREEN") |> PrefixedName

    /// <summary>
    ///   <para>hard:InputDevice_TRACK_BALL</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:InputDevice</para>
    ///   <para>"A little sphere that acts like a trackball mouse"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Track Ball"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_TRACK_BALL">http://www.w3.org/2007/uwa/context/hardware.owl#InputDevice_TRACK_BALL</seealso>
    let InputDevice_TRACK_BALL =
        Prefixed_Name(hard, "InputDevice_TRACK_BALL") |> PrefixedName

    /// <summary>
    ///   <para>hard:Keyboard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a keyboard in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Keyboard"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Keyboard">http://www.w3.org/2007/uwa/context/hardware.owl#Keyboard</seealso>
    let Keyboard = Prefixed_Name(hard, "Keyboard") |> PrefixedName
    /// <summary>
    ///   <para>hard:MemoryCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a storage card which can be attached to a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Memory Card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#MemoryCard">http://www.w3.org/2007/uwa/context/hardware.owl#MemoryCard</seealso>
    let MemoryCard = Prefixed_Name(hard, "MemoryCard") |> PrefixedName
    /// <summary>
    ///   <para>hard:MemoryUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents some memory used in a device. It might, for example, be built-in memory that is part of the device, or it might be removable memory on some form of storage card"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Memory Unit"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#MemoryUnit">http://www.w3.org/2007/uwa/context/hardware.owl#MemoryUnit</seealso>
    let MemoryUnit = Prefixed_Name(hard, "MemoryUnit") |> PrefixedName
    /// <summary>
    ///   <para>hard:Microphone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a microphone in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Microphone"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Microphone">http://www.w3.org/2007/uwa/context/hardware.owl#Microphone</seealso>
    let Microphone = Prefixed_Name(hard, "Microphone") |> PrefixedName
    /// <summary>
    ///   <para>hard:NfcHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the NFC hardware on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"NFC Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#NfcHardware">http://www.w3.org/2007/uwa/context/hardware.owl#NfcHardware</seealso>
    let NfcHardware = Prefixed_Name(hard, "NfcHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:OutputDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents an output mechanism that can be available in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Output Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#OutputDevice">http://www.w3.org/2007/uwa/context/hardware.owl#OutputDevice</seealso>
    let OutputDevice = Prefixed_Name(hard, "OutputDevice") |> PrefixedName
    /// <summary>
    ///   <para>hard:PointingResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents the precision with which the pointing can be achieved on a  device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pointing Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution">http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution</seealso>
    let PointingResolution = Prefixed_Name(hard, "PointingResolution") |> PrefixedName

    /// <summary>
    ///   <para>hard:PointingResolution_CHAR</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:PointingResolution</para>
    ///   <para>"The pointing device can select an individual character"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Character Pointing Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_CHAR">http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_CHAR</seealso>
    let PointingResolution_CHAR =
        Prefixed_Name(hard, "PointingResolution_CHAR") |> PrefixedName

    /// <summary>
    ///   <para>hard:PointingResolution_LINE</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:PointingResolution</para>
    ///   <para>"The pointing device can select a line of text"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Line Pointing Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_LINE">http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_LINE</seealso>
    let PointingResolution_LINE =
        Prefixed_Name(hard, "PointingResolution_LINE") |> PrefixedName

    /// <summary>
    ///   <para>hard:PointingResolution_PIXEL</para>
    /// </summary>
    /// <remarks>
    ///   <para>hard:PointingResolution</para>
    ///   <para>"The pointing device can select an individual pixel"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pixel Pointing Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_PIXEL">http://www.w3.org/2007/uwa/context/hardware.owl#PointingResolution_PIXEL</seealso>
    let PointingResolution_PIXEL =
        Prefixed_Name(hard, "PointingResolution_PIXEL") |> PrefixedName

    /// <summary>
    ///   <para>hard:Sibling_Disjoint</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Sibling_Disjoint">http://www.w3.org/2007/uwa/context/hardware.owl#Sibling_Disjoint</seealso>
    let Sibling_Disjoint = Prefixed_Name(hard, "Sibling_Disjoint") |> PrefixedName
    /// <summary>
    ///   <para>hard:Sibling_Disjoint2</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:AllDisjointSet</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Sibling_Disjoint2">http://www.w3.org/2007/uwa/context/hardware.owl#Sibling_Disjoint2</seealso>
    let Sibling_Disjoint2 = Prefixed_Name(hard, "Sibling_Disjoint2") |> PrefixedName
    /// <summary>
    ///   <para>hard:Speaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents a speaker component in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Speaker"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#Speaker">http://www.w3.org/2007/uwa/context/hardware.owl#Speaker</seealso>
    let Speaker = Prefixed_Name(hard, "Speaker") |> PrefixedName
    /// <summary>
    ///   <para>hard:TactileDisplay</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A display that is tac-sensitive, allowing users to interact directly with the objects shown on the screen"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tactile Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#TactileDisplay">http://www.w3.org/2007/uwa/context/hardware.owl#TactileDisplay</seealso>
    let TactileDisplay = Prefixed_Name(hard, "TactileDisplay") |> PrefixedName
    /// <summary>
    ///   <para>hard:TermGroup_Hardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>common:TermGroup</para>
    ///   <para>"A group of terms with properties, classes and instances that model the hardware elements of a Delivery Context"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#TermGroup_Hardware">http://www.w3.org/2007/uwa/context/hardware.owl#TermGroup_Hardware</seealso>
    let TermGroup_Hardware = Prefixed_Name(hard, "TermGroup_Hardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:WiFiHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class represents  hardware in a device that can be used to access to WiFi networks"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"WiFi Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#WiFiHardware">http://www.w3.org/2007/uwa/context/hardware.owl#WiFiHardware</seealso>
    let WiFiHardware = Prefixed_Name(hard, "WiFiHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:availableSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the amount of memory available for use, in bytes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Available Memory Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#availableSize">http://www.w3.org/2007/uwa/context/hardware.owl#availableSize</seealso>
    let availableSize = Prefixed_Name(hard, "availableSize") |> PrefixedName
    /// <summary>
    ///   <para>hard:battery</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents one or more batteries in a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#battery">http://www.w3.org/2007/uwa/context/hardware.owl#battery</seealso>
    let battery = Prefixed_Name(hard, "battery") |> PrefixedName
    /// <summary>
    ///   <para>hard:batteryBeingCharged</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property indicates whether the battery is currently being charged or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery Being Charged"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#batteryBeingCharged">http://www.w3.org/2007/uwa/context/hardware.owl#batteryBeingCharged</seealso>
    let batteryBeingCharged = Prefixed_Name(hard, "batteryBeingCharged") |> PrefixedName
    /// <summary>
    ///   <para>hard:batteryCapacity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The capacity of a battery, as an amount of electric charge that it can store, measured in ampere-hours"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery Capacity"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#batteryCapacity">http://www.w3.org/2007/uwa/context/hardware.owl#batteryCapacity</seealso>
    let batteryCapacity = Prefixed_Name(hard, "batteryCapacity") |> PrefixedName
    /// <summary>
    ///   <para>hard:batteryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property holds the percentage of the battery capacity that remains available"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Battery Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#batteryLevel">http://www.w3.org/2007/uwa/context/hardware.owl#batteryLevel</seealso>
    let batteryLevel = Prefixed_Name(hard, "batteryLevel") |> PrefixedName
    /// <summary>
    ///   <para>hard:bluetoothAddress</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Bluetooth address of the device represented in hexadecimal format. he Bluetooth address will be 12 characters long. Valid characters are 0-9 and A-F"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Address"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothAddress">http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothAddress</seealso>
    let bluetoothAddress = Prefixed_Name(hard, "bluetoothAddress") |> PrefixedName
    /// <summary>
    ///   <para>hard:bluetoothName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The Bluetooth friendly name of the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Friendly Name"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothName">http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothName</seealso>
    let bluetoothName = Prefixed_Name(hard, "bluetoothName") |> PrefixedName
    /// <summary>
    ///   <para>hard:bluetoothStatus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates the Bluetooth Status of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Bluetooth Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothStatus">http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothStatus</seealso>
    let bluetoothStatus = Prefixed_Name(hard, "bluetoothStatus") |> PrefixedName
    /// <summary>
    ///   <para>hard:bluetoothVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the version/s of Bluetooth supported"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Bluetooth Version"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothVersion">http://www.w3.org/2007/uwa/context/hardware.owl#bluetoothVersion</seealso>
    let bluetoothVersion = Prefixed_Name(hard, "bluetoothVersion") |> PrefixedName
    /// <summary>
    ///   <para>hard:builtInMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the memory built into the device and which is not removable during normal operation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Built-in Memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#builtInMemory">http://www.w3.org/2007/uwa/context/hardware.owl#builtInMemory</seealso>
    let builtInMemory = Prefixed_Name(hard, "builtInMemory") |> PrefixedName
    /// <summary>
    ///   <para>hard:colorDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Count the number of bits used for color definition"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Color Depth"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#colorDepth">http://www.w3.org/2007/uwa/context/hardware.owl#colorDepth</seealso>
    let colorDepth = Prefixed_Name(hard, "colorDepth") |> PrefixedName
    /// <summary>
    ///   <para>hard:cpu</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a CPU for a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CPU"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#cpu">http://www.w3.org/2007/uwa/context/hardware.owl#cpu</seealso>
    let cpu = Prefixed_Name(hard, "cpu") |> PrefixedName
    /// <summary>
    ///   <para>hard:currentOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DataRange</para>
    ///   <para>"This property represents the current orientation of a display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Orientation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#currentOrientation">http://www.w3.org/2007/uwa/context/hardware.owl#currentOrientation</seealso>
    let currentOrientation = Prefixed_Name(hard, "currentOrientation") |> PrefixedName
    /// <summary>
    ///   <para>hard:deviceHardware</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the hardware associated with a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device Hardware"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#deviceHardware">http://www.w3.org/2007/uwa/context/hardware.owl#deviceHardware</seealso>
    let deviceHardware = Prefixed_Name(hard, "deviceHardware") |> PrefixedName
    /// <summary>
    ///   <para>hard:deviceIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Identifies univoquely a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Device Identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#deviceIdentifier">http://www.w3.org/2007/uwa/context/hardware.owl#deviceIdentifier</seealso>
    let deviceIdentifier = Prefixed_Name(hard, "deviceIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>hard:display</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a display associated with a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#display">http://www.w3.org/2007/uwa/context/hardware.owl#display</seealso>
    let display = Prefixed_Name(hard, "display") |> PrefixedName
    /// <summary>
    ///   <para>hard:extensionMemory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property identifies additional memory that is provided to a device, typically in the form of removable memory cards"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Extension Memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#extensionMemory">http://www.w3.org/2007/uwa/context/hardware.owl#extensionMemory</seealso>
    let extensionMemory = Prefixed_Name(hard, "extensionMemory") |> PrefixedName
    /// <summary>
    ///   <para>hard:hardwareComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a hardware component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Hardware Component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#hardwareComponent">http://www.w3.org/2007/uwa/context/hardware.owl#hardwareComponent</seealso>
    let hardwareComponent = Prefixed_Name(hard, "hardwareComponent") |> PrefixedName
    /// <summary>
    ///   <para>hard:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The total height of something as a linear measure in centimeters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Height"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#height">http://www.w3.org/2007/uwa/context/hardware.owl#height</seealso>
    let height = Prefixed_Name(hard, "height") |> PrefixedName
    /// <summary>
    ///   <para>hard:imei</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The International Mobile Equipment Identity or IMEI is a number unique to every GSM and UMTS mobile phone."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"IMEI"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#imei">http://www.w3.org/2007/uwa/context/hardware.owl#imei</seealso>
    let imei = Prefixed_Name(hard, "imei") |> PrefixedName
    /// <summary>
    ///   <para>hard:inputCharacterSets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines the character sets supported by the device for input"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input Character Sets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#inputCharacterSets">http://www.w3.org/2007/uwa/context/hardware.owl#inputCharacterSets</seealso>
    let inputCharacterSets = Prefixed_Name(hard, "inputCharacterSets") |> PrefixedName
    /// <summary>
    ///   <para>hard:inputDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The input mechanisms supported by a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Input Devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#inputDevice">http://www.w3.org/2007/uwa/context/hardware.owl#inputDevice</seealso>
    let inputDevice = Prefixed_Name(hard, "inputDevice") |> PrefixedName
    /// <summary>
    ///   <para>hard:isTethered</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property states whether this Device is actuating "tethered" to another Device, giving the latter some kind of wireless connection"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Tethered"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#isTethered">http://www.w3.org/2007/uwa/context/hardware.owl#isTethered</seealso>
    let isTethered = Prefixed_Name(hard, "isTethered") |> PrefixedName
    /// <summary>
    ///   <para>hard:maxCpuFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Processor maximum speed"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"CPU Maximum Frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#maxCpuFrequency">http://www.w3.org/2007/uwa/context/hardware.owl#maxCpuFrequency</seealso>
    let maxCpuFrequency = Prefixed_Name(hard, "maxCpuFrequency") |> PrefixedName
    /// <summary>
    ///   <para>hard:meid</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Mobile Equipment Identifier (MEID) is a globally unique number identifying a physical piece of CDMA mobile station equipment. The number format is defined by the 3GPP2 standard S.R0048 but in practical terms, it can be seen as an IMEI but with hexadecimal digits"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"MEID"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#meid">http://www.w3.org/2007/uwa/context/hardware.owl#meid</seealso>
    let meid = Prefixed_Name(hard, "meid") |> PrefixedName
    /// <summary>
    ///   <para>hard:memory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the hardware memory component/s of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Memory"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#memory">http://www.w3.org/2007/uwa/context/hardware.owl#memory</seealso>
    let memory = Prefixed_Name(hard, "memory") |> PrefixedName
    /// <summary>
    ///   <para>hard:muted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Indicates if a speaker or microphone is muted or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Muted"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#muted">http://www.w3.org/2007/uwa/context/hardware.owl#muted</seealso>
    let muted = Prefixed_Name(hard, "muted") |> PrefixedName
    /// <summary>
    ///   <para>hard:outputCharacterSets</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines the character sets supported by the device for output"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Output Character Sets"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#outputCharacterSets">http://www.w3.org/2007/uwa/context/hardware.owl#outputCharacterSets</seealso>
    let outputCharacterSets = Prefixed_Name(hard, "outputCharacterSets") |> PrefixedName
    /// <summary>
    ///   <para>hard:outputDevice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The output mechanisms supported by a Device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Output Devices"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#outputDevice">http://www.w3.org/2007/uwa/context/hardware.owl#outputDevice</seealso>
    let outputDevice = Prefixed_Name(hard, "outputDevice") |> PrefixedName
    /// <summary>
    ///   <para>hard:pointingResolution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the precision with which pointing can be carried out on a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Pointing Resolution"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#pointingResolution">http://www.w3.org/2007/uwa/context/hardware.owl#pointingResolution</seealso>
    let pointingResolution = Prefixed_Name(hard, "pointingResolution") |> PrefixedName
    /// <summary>
    ///   <para>hard:primary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a relationship between the device hardware and the primary components it contains"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Primary"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#primary">http://www.w3.org/2007/uwa/context/hardware.owl#primary</seealso>
    let primary = Prefixed_Name(hard, "primary") |> PrefixedName
    /// <summary>
    ///   <para>hard:primaryCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the primary camera of  a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Primary Camera"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#primaryCamera">http://www.w3.org/2007/uwa/context/hardware.owl#primaryCamera</seealso>
    let primaryCamera = Prefixed_Name(hard, "primaryCamera") |> PrefixedName
    /// <summary>
    ///   <para>hard:secondaryCamera</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents a secondary camera of a device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Secondary Camera"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#secondaryCamera">http://www.w3.org/2007/uwa/context/hardware.owl#secondaryCamera</seealso>
    let secondaryCamera = Prefixed_Name(hard, "secondaryCamera") |> PrefixedName
    /// <summary>
    ///   <para>hard:size</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property represents the total size of a hardware element (memory, registry, etc.) in bytes"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Size"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#size">http://www.w3.org/2007/uwa/context/hardware.owl#size</seealso>
    let size = Prefixed_Name(hard, "size") |> PrefixedName
    /// <summary>
    ///   <para>hard:softkeyNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property represents the number of input keys on the keyboard whose function can be controlled programatically"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Number of Soft Keys"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#softkeyNumber">http://www.w3.org/2007/uwa/context/hardware.owl#softkeyNumber</seealso>
    let softkeyNumber = Prefixed_Name(hard, "softkeyNumber") |> PrefixedName
    /// <summary>
    ///   <para>hard:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property represents the status of a hardware component"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Status"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#status">http://www.w3.org/2007/uwa/context/hardware.owl#status</seealso>
    let status = Prefixed_Name(hard, "status") |> PrefixedName

    /// <summary>
    ///   <para>hard:supportedBluetoothProfiles</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property defines the Bluetooth profiles supported by the device"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Bluetooth Profiles"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#supportedBluetoothProfiles">http://www.w3.org/2007/uwa/context/hardware.owl#supportedBluetoothProfiles</seealso>
    let supportedBluetoothProfiles =
        Prefixed_Name(hard, "supportedBluetoothProfiles") |> PrefixedName

    /// <summary>
    ///   <para>hard:supportedOrientations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DataRange</para>
    ///   <para>"This property holds the supported orientations of a display"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Supported Orientation"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#supportedOrientations">http://www.w3.org/2007/uwa/context/hardware.owl#supportedOrientations</seealso>
    let supportedOrientations =
        Prefixed_Name(hard, "supportedOrientations") |> PrefixedName

    /// <summary>
    ///   <para>hard:thickness</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The thickness of something measured in centimeters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Thickness"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#thickness">http://www.w3.org/2007/uwa/context/hardware.owl#thickness</seealso>
    let thickness = Prefixed_Name(hard, "thickness") |> PrefixedName
    /// <summary>
    ///   <para>hard:volatile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"This property indicates if the memory unit is volatile or not"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volatile"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#volatile">http://www.w3.org/2007/uwa/context/hardware.owl#volatile</seealso>
    let volatile = Prefixed_Name(hard, "volatile") |> PrefixedName
    /// <summary>
    ///   <para>hard:volumeLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The relative volume level of a speaker (between 0 and 100)"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Volume Level"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#volumeLevel">http://www.w3.org/2007/uwa/context/hardware.owl#volumeLevel</seealso>
    let volumeLevel = Prefixed_Name(hard, "volumeLevel") |> PrefixedName
    /// <summary>
    ///   <para>hard:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The weight of something physical, measured in kilos"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Weight"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#weight">http://www.w3.org/2007/uwa/context/hardware.owl#weight</seealso>
    let weight = Prefixed_Name(hard, "weight") |> PrefixedName
    /// <summary>
    ///   <para>hard:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The total width of something as a linear measure, measured in centimeters"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Width"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://www.w3.org/2007/uwa/context/hardware.owl#width">http://www.w3.org/2007/uwa/context/hardware.owl#width</seealso>
    let width = Prefixed_Name(hard, "width") |> PrefixedName
