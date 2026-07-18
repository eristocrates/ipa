namespace https.w3id.org.usability.hash

open DoxAletheia.Rdf_Vocabulary

module usability =
    let _namespace_name = "https://w3id.org/usability#"

    /// <summary>
    /// The base class for events which are user actions related to user interation with the interface (clicks, mouse movements, etc.)
    /// <see href="https://w3id.org/usability#ActionEvent"></see></summary>
    let ActionEvent =
        Namespaced_IRI.parse _namespace_name "ActionEvent" |> NamespacedName

    /// <summary>
    /// The base class for all different kinds of event that may be occured while the user is interacting with the software
    /// <see href="https://w3id.org/usability#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

    /// <summary>
    /// The class that represents any mouse click
    /// <see href="https://w3id.org/usability#ClickMouseActionEvent"></see></summary>
    let ClickMouseActionEvent =
        Namespaced_IRI.parse _namespace_name "ClickMouseActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasInRegionY"></see>
    /// </summary>
    let hasInRegionY =
        Namespaced_IRI.parse _namespace_name "hasInRegionY" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasInRegionX"></see>
    /// </summary>
    let hasInRegionX =
        Namespaced_IRI.parse _namespace_name "hasInRegionX" |> NamespacedName

    /// <summary>
    /// The class that represents actions related to user's manipulations with a mouse
    /// <see href="https://w3id.org/usability#MouseActionEvent"></see></summary>
    let MouseActionEvent =
        Namespaced_IRI.parse _namespace_name "MouseActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#Command"></see>
    /// </summary>
    let Command = Namespaced_IRI.parse _namespace_name "Command" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName

    /// <summary>
    /// The class that represents events, related with the fact of calling a certain command (function) by the user
    /// <see href="https://w3id.org/usability#CommandEvent"></see></summary>
    let CommandEvent =
        Namespaced_IRI.parse _namespace_name "CommandEvent" |> NamespacedName

    /// <summary>
    /// The property that associates specific command with the event in which the command was called
    /// <see href="https://w3id.org/usability#wasInvokedIn"></see></summary>
    let wasInvokedIn =
        Namespaced_IRI.parse _namespace_name "wasInvokedIn" |> NamespacedName

    /// <summary>
    /// A transitive property which determines that some object is contained/stored/located inside of some subject. Inverse of contains
    /// <see href="https://w3id.org/usability#isContainedIn"></see></summary>
    let isContainedIn =
        Namespaced_IRI.parse _namespace_name "isContainedIn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandA"></see>
    /// </summary>
    let CommandA = Namespaced_IRI.parse _namespace_name "CommandA" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandB"></see>
    /// </summary>
    let CommandB = Namespaced_IRI.parse _namespace_name "CommandB" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation211"></see>
    /// </summary>
    let RegionVariation211 =
        Namespaced_IRI.parse _namespace_name "RegionVariation211" |> NamespacedName

    /// <summary>
    /// The property that associates command event with the specific command instance
    /// <see href="https://w3id.org/usability#wasAssociatedWith"></see></summary>
    let wasAssociatedWith =
        Namespaced_IRI.parse _namespace_name "wasAssociatedWith" |> NamespacedName

    /// <summary>
    /// A transitive property which determines that some subject contains/stores some object inside of it. Inverse of isContainedIn
    /// <see href="https://w3id.org/usability#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent1113"></see>
    /// </summary>
    let CommandEvent1113 =
        Namespaced_IRI.parse _namespace_name "CommandEvent1113" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation111"></see>
    /// </summary>
    let RegionVariation111 =
        Namespaced_IRI.parse _namespace_name "RegionVariation111" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent1114"></see>
    /// </summary>
    let CommandEvent1114 =
        Namespaced_IRI.parse _namespace_name "CommandEvent1114" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#CommandEvent2112"></see>
    /// </summary>
    let CommandEvent2112 =
        Namespaced_IRI.parse _namespace_name "CommandEvent2112" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#Device"></see>
    /// </summary>
    let Device = Namespaced_IRI.parse _namespace_name "Device" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasUid"></see>
    /// </summary>
    let hasUid = Namespaced_IRI.parse _namespace_name "hasUid" |> NamespacedName
    /// <summary>
    /// A period of time when a user interacts with the software
    /// <see href="https://w3id.org/usability#Session"></see></summary>
    let Session = Namespaced_IRI.parse _namespace_name "Session" |> NamespacedName
    /// <summary>
    /// The property that associates a device with the sessions which were run on that device
    /// <see href="https://w3id.org/usability#wasUsedIn"></see></summary>
    let wasUsedIn = Namespaced_IRI.parse _namespace_name "wasUsedIn" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Device1"></see>
    /// </summary>
    let Device1 = Namespaced_IRI.parse _namespace_name "Device1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Session2"></see>
    /// </summary>
    let Session2 = Namespaced_IRI.parse _namespace_name "Session2" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Session1"></see>
    /// </summary>
    let Session1 = Namespaced_IRI.parse _namespace_name "Session1" |> NamespacedName

    /// <summary>
    /// The class that represents a double mouse click
    /// <see href="https://w3id.org/usability#DoubleClickMouseEvent"></see></summary>
    let DoubleClickMouseEvent =
        Namespaced_IRI.parse _namespace_name "DoubleClickMouseEvent" |> NamespacedName

    /// <summary>
    /// The class that represents double tap - two short taps on the screen
    /// <see href="https://w3id.org/usability#DoubleTapTouchActionEvent"></see></summary>
    let DoubleTapTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "DoubleTapTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents differend kinds events related to user's tap on the touch screen
    /// <see href="https://w3id.org/usability#TapTouchActionEvent"></see></summary>
    let TapTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "TapTouchActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDateTime"></see>
    /// </summary>
    let hasDateTime =
        Namespaced_IRI.parse _namespace_name "hasDateTime" |> NamespacedName

    /// <summary>
    /// Class that describes a region variation, since a region may have one or more variations. Variation is a unique combination of region image's height and width, or their range
    /// <see href="https://w3id.org/usability#Variation"></see></summary>
    let Variation = Namespaced_IRI.parse _namespace_name "Variation" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1111"></see>
    /// </summary>
    let Event1111 = Namespaced_IRI.parse _namespace_name "Event1111" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1112"></see>
    /// </summary>
    let Event1112 = Namespaced_IRI.parse _namespace_name "Event1112" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1121"></see>
    /// </summary>
    let Event1121 = Namespaced_IRI.parse _namespace_name "Event1121" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event1122"></see>
    /// </summary>
    let Event1122 = Namespaced_IRI.parse _namespace_name "Event1122" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Event2111"></see>
    /// </summary>
    let Event2111 = Namespaced_IRI.parse _namespace_name "Event2111" |> NamespacedName

    /// <summary>
    /// The class that represents touch-and-hold action - continuous touch with a single finger
    /// <see href="https://w3id.org/usability#HoldTapTouchActionEvent"></see></summary>
    let HoldTapTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "HoldTapTouchActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDpiX"></see>
    /// </summary>
    let hasDpiX = Namespaced_IRI.parse _namespace_name "hasDpiX" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasHeight"></see>
    /// </summary>
    let hasHeight = Namespaced_IRI.parse _namespace_name "hasHeight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasBinaryData"></see>
    /// </summary>
    let hasBinaryData =
        Namespaced_IRI.parse _namespace_name "hasBinaryData" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasWidth"></see>
    /// </summary>
    let hasWidth = Namespaced_IRI.parse _namespace_name "hasWidth" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#hasDpiY"></see>
    /// </summary>
    let hasDpiY = Namespaced_IRI.parse _namespace_name "hasDpiY" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image111"></see>
    /// </summary>
    let Image111 = Namespaced_IRI.parse _namespace_name "Image111" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image112"></see>
    /// </summary>
    let Image112 = Namespaced_IRI.parse _namespace_name "Image112" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#Image211"></see>
    /// </summary>
    let Image211 = Namespaced_IRI.parse _namespace_name "Image211" |> NamespacedName

    /// <summary>
    /// The class that represents actions related to user's manipulations with a keyboard
    /// <see href="https://w3id.org/usability#KeyboardActionEvent"></see></summary>
    let KeyboardActionEvent =
        Namespaced_IRI.parse _namespace_name "KeyboardActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents touch - a touch that is slightly longer then tap
    /// <see href="https://w3id.org/usability#LongTapTouchActionEvent"></see></summary>
    let LongTapTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "LongTapTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents movements of cursor. hasInRegionX and hasInRegionY properties store information about the new cursor coordinates after the movement
    /// <see href="https://w3id.org/usability#MoveMouseActionEvent"></see></summary>
    let MoveMouseActionEvent =
        Namespaced_IRI.parse _namespace_name "MoveMouseActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents pinch - a contractive movement with two fingers on the screen to scale down the image.
    /// <see href="https://w3id.org/usability#PinchTouchActionEvent"></see></summary>
    let PinchTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "PinchTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents events related to user interations with touchscreen, like smartphone or tablet PC
    /// <see href="https://w3id.org/usability#TouchActionEvent"></see></summary>
    let TouchActionEvent =
        Namespaced_IRI.parse _namespace_name "TouchActionEvent" |> NamespacedName

    /// <summary>
    /// A fragment of GUI, for example, the whole window, or a part of it
    /// <see href="https://w3id.org/usability#Region"></see></summary>
    let Region = Namespaced_IRI.parse _namespace_name "Region" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMinHeight"></see>
    /// </summary>
    let hasMinHeight =
        Namespaced_IRI.parse _namespace_name "hasMinHeight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMaxWidth"></see>
    /// </summary>
    let hasMaxWidth =
        Namespaced_IRI.parse _namespace_name "hasMaxWidth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMaxHeight"></see>
    /// </summary>
    let hasMaxHeight =
        Namespaced_IRI.parse _namespace_name "hasMaxHeight" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasMinWidth"></see>
    /// </summary>
    let hasMinWidth =
        Namespaced_IRI.parse _namespace_name "hasMinWidth" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#Region11"></see>
    /// </summary>
    let Region11 = Namespaced_IRI.parse _namespace_name "Region11" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#RegionVariation112"></see>
    /// </summary>
    let RegionVariation112 =
        Namespaced_IRI.parse _namespace_name "RegionVariation112" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#Region21"></see>
    /// </summary>
    let Region21 = Namespaced_IRI.parse _namespace_name "Region21" |> NamespacedName
    /// <summary>
    /// The property which associate some region variation with its image
    /// <see href="https://w3id.org/usability#hasImage"></see></summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName

    /// <summary>
    /// The class that represents a mouse wheel scroll
    /// <see href="https://w3id.org/usability#ScrollMouseActionEvent"></see></summary>
    let ScrollMouseActionEvent =
        Namespaced_IRI.parse _namespace_name "ScrollMouseActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasEndDateTime"></see>
    /// </summary>
    let hasEndDateTime =
        Namespaced_IRI.parse _namespace_name "hasEndDateTime" |> NamespacedName

    /// <summary>
    /// The property that associates a session with the device on which the session was run
    /// <see href="https://w3id.org/usability#wasPerformedOn"></see></summary>
    let wasPerformedOn =
        Namespaced_IRI.parse _namespace_name "wasPerformedOn" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasStartDateTime"></see>
    /// </summary>
    let hasStartDateTime =
        Namespaced_IRI.parse _namespace_name "hasStartDateTime" |> NamespacedName

    /// <summary>
    /// The user who runs sessions
    /// <see href="https://w3id.org/usability#User"></see></summary>
    let User = Namespaced_IRI.parse _namespace_name "User" |> NamespacedName

    /// <summary>
    /// The property that associates a session with the user who performed it
    /// <see href="https://w3id.org/usability#wasPerformedBy"></see></summary>
    let wasPerformedBy =
        Namespaced_IRI.parse _namespace_name "wasPerformedBy" |> NamespacedName

    /// <summary>
    /// The class that represents a single mouse click
    /// <see href="https://w3id.org/usability#SingleClickMouseEvent"></see></summary>
    let SingleClickMouseEvent =
        Namespaced_IRI.parse _namespace_name "SingleClickMouseEvent" |> NamespacedName

    /// <summary>
    /// The class that represents tap action - single short touch with one finger
    /// <see href="https://w3id.org/usability#SingleTapTouchActionEvent"></see></summary>
    let SingleTapTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "SingleTapTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents stretch (pinch it open) - tensile movement with two fingers on the screen to enlarge the image.
    /// <see href="https://w3id.org/usability#StretchTouchActionEvent"></see></summary>
    let StretchTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "StretchTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class the represents swipe (slide) - a continuous movement of the finger across the screen
    /// <see href="https://w3id.org/usability#SwipeTouchActionEvent"></see></summary>
    let SwipeTouchActionEvent =
        Namespaced_IRI.parse _namespace_name "SwipeTouchActionEvent" |> NamespacedName

    /// <summary>
    /// The class that represents clicks on a keyboard
    /// <see href="https://w3id.org/usability#TypeKeyboardActionEvent"></see></summary>
    let TypeKeyboardActionEvent =
        Namespaced_IRI.parse _namespace_name "TypeKeyboardActionEvent" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#performed"></see>
    /// </summary>
    let performed = Namespaced_IRI.parse _namespace_name "performed" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#User1"></see>
    /// </summary>
    let User1 = Namespaced_IRI.parse _namespace_name "User1" |> NamespacedName
    /// <summary>
    ///   <see href="https://w3id.org/usability#User2"></see>
    /// </summary>
    let User2 = Namespaced_IRI.parse _namespace_name "User2" |> NamespacedName

    /// <summary>
    ///   <see href="https://w3id.org/usability#hasCommandName"></see>
    /// </summary>
    let hasCommandName =
        Namespaced_IRI.parse _namespace_name "hasCommandName" |> NamespacedName

    /// <summary>
    /// The property that associates an image with the corresponding region variation
    /// <see href="https://w3id.org/usability#wasImaged"></see></summary>
    let wasImaged = Namespaced_IRI.parse _namespace_name "wasImaged" |> NamespacedName
